import matplotlib.pyplot as plt
import matplotlib.patches as patches
import numpy as np
import sympy

sx = sympy.Symbol('x')
MAX_ITER = 40

# Pirma funkcija (f(x))
def fx(ax):
    return 1.03*ax**5 - 2.91*ax**4 - 1.44*ax**3 + 5.56*ax**2 - 0.36*ax -1.13

#f(x) isvestine
fxD = sympy.lambdify(sx, (1.03*sx**5 - 2.91*sx**4 - 1.44*sx**3 + 5.56*sx**2 - 0.36*sx - 1.13).diff(), 'numpy')

#Skenavimas nekintanciu zingsniu
def scanFixed(func, xFrom, xTo, step):
    intervals = []
    current = xFrom

    while current <= xTo:                       #Skenavimas
        left = current
        right = current + step
        current += step

        if np.sign(func(left)) != np.sign(func(right)):
            intervals.append((left, right))     #Saknies intervalas
    
    return intervals

#Tikslinimas stygu metodu
def stringAdjusment(func, xFrom, xTo, precision):
    xLeft = xFrom
    xRight = xTo

    iterations = 0

    while True:
        iterations += 1

        k = abs(func(xLeft)/func(xRight))
        xMid = (xLeft + k * xRight) / (1 + k)

        if np.sign(func(xMid)) == np.sign(func(xLeft)):
            xLeft = xMid
        else:
            xRight = xMid

        if abs(func(xMid)) < precision:
            return xMid, iterations

#Tikslinimas niotono(liestiniu) metodu
def newtonAdjusment(func, funcD, xFrom, xTo, precision):
    xo = xFrom
    iterations = 0

    for i in range(0, MAX_ITER):
        iterations += 1

        if abs(func(xo)) < precision:
            return xo, iterations

        if funcD(xo) == 0:
            return xo, iterations

        xo = xo - (func(xo)/funcD(xo))

    return None, iterations

#Skenavimas mazejanciu zingsniu
def scanDecreasing(func, xFrom, xTo, step, precision):
    
    width = step

    left = xFrom
    right = xFrom + width

    iterations = 0

    while width > precision:                       #Skenavimas
        iterations += 1

        if np.sign(func(left)) == np.sign(func(right)): #Saknies intervale nera
            left = right
            right = right + width
        else:                                           #Saknis yra intervale
            width = width / 4                           #Zingsnis mazinamas
            right = left + width
    
    return left, iterations

fxRootIntervals = scanFixed(fx, -3.32, 3.83, 0.1)
print(fxRootIntervals)

x = np.linspace(-3.32, 3.83, 500)
plt.ylim(-6, 4)
plt.plot(x,fx(x))
plt.grid(True)
plt.show()