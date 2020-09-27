import matplotlib.pyplot as plt
import matplotlib.patches as patches
import numpy as np
import sympy

sx = sympy.Symbol('x')
MAX_ITER = 40

#Lygtis
def T(x):
    return 80*(np.exp(30*x)) - 24

#Isvestine
TtD = sympy.lambdify(sx, (80*(sympy.exp(30*sx)) - 24).diff(), 'numpy')

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

#Tikslinimas niotono(liestiniu) metodu
def newtonAdjusment(func, funcD, xFrom, xTo, precision = 1e-8):
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

#Intervalas
interval = scanFixed(T, -8, 1, 0.1)[0]

#Tikslinimas
root, iterations = newtonAdjusment(T, TtD, interval[0], interval[1])

print("Lygties saknis: ", root, "\nSaknis rasta per ", iterations, " iteraciju")
