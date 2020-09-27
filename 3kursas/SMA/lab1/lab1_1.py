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

#Antra funkcija g(x)
def gx(ax):
    return np.sin(ax) * np.log(ax) - ax/6

#g(x) isvestine
gxD = sympy.lambdify(sx, (sympy.sin(sx) * sympy.log(sx) - sx/6).diff(), 'numpy')

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
def stringAdjusment(func, xFrom, xTo, precision = 1e-8):
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

#Skenavimas mazejanciu zingsniu
def scanDecreasing(func, xFrom, xTo, step, precision = 1e-8):
    
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
    
step = 0.1
fxIntervals = scanFixed(fx,-3.32, 3.83, step)
gxIntervals = scanFixed(gx, 1, 20, step)

print("f(x) intervalai:", fxIntervals)
print("g(x) intervalai:", gxIntervals, "\n")

stringRoots = []
stringIterations = []

newtonRoots = []
newtonIterations = []

scanRoots = []
scanIterations = []

for interval in fxIntervals:
    left, right = interval

    sRoot, sIt = stringAdjusment(fx, left, right)
    stringRoots.append(sRoot)
    stringIterations.append(sIt)

    nRoot, nIt = newtonAdjusment(fx, fxD, left, right)
    newtonRoots.append(nRoot)
    newtonIterations.append(nIt)

    scRoot, scIt = scanDecreasing(fx, left, right, 0.05)
    scanRoots.append(scRoot)
    scanIterations.append(scIt)

print("    Numpy šaknys f(x):", sorted(np.roots([1.03, -2.91, -1.44, 5.56, -0.36, -1.13])))
print("    Stygų šaknys f(x):", stringRoots)
print("  Niutono šaknys f(x):", newtonRoots)
print("Skenavimo šaknys f(x)", scanRoots, "\n")

print("    Stygų šaknų iteracijos f(x):", stringIterations)
print("  Niutono šaknų iteracijos f(x):", newtonIterations)
print("Skenavimo šaknų iteracijos f(x):", scanIterations, "\n")

stringRoots = []
stringIterations = []

newtonRoots = []
newtonIterations = []

scanRoots = []
scanIterations = []

for interval in gxIntervals:
    left, right = interval

    sRoot, sIt = stringAdjusment(gx, left, right)
    stringRoots.append(sRoot)
    stringIterations.append(sIt)

    nRoot, nIt = newtonAdjusment(gx, gxD, left, right)
    newtonRoots.append(nRoot)
    newtonIterations.append(nIt)

    scRoot, scIt = scanDecreasing(gx, left, right, 0.05)
    scanRoots.append(scRoot)
    scanIterations.append(scIt)

print("    Stygų šaknys g(x):", stringRoots)
print("  Niutono šaknys g(x):", newtonRoots)
print("Skenavimo šaknys g(x)", scanRoots, "\n")

print("    Stygų šaknų iteracijos g(x):", stringIterations)
print("  Niutono šaknų iteracijos g(x):", newtonIterations)
print("Skenavimo šaknų iteracijos g(x):", scanIterations, "\n")

gx_x = np.linspace(1, 20, 500)
gx_y = np.apply_along_axis(gx, 0, gx_x)

fx_x = np.linspace(-3.32, 3.83, 500)
fx_y = np.apply_along_axis(fx, 0, fx_x)

plt.figure(figsize=(15, 5))

plt.subplot(1, 2, 1)
plt.gca().set_title("f(x)")
plt.axhline(0)
plt.axvline(0)

plt.plot([-3.32, -3.32], [-5, 5], linestyle="dashed", c="green")
plt.plot([3.83, 3.83], [-5, 5], linestyle="dashed", c="green")

for interval in fxIntervals:
    left, right = interval

    rect = patches.Rectangle((left, -0.25), step, 0.5, linewidth=1, edgecolor='g', facecolor='g', alpha=0.3)
    plt.gca().add_patch(rect)


plt.ylim(-6, 4)
plt.plot(fx_x,fx_y, c="black")

plt.subplot(1, 2, 2)
plt.gca().set_title("g(x)")
plt.axhline(0)

for interval in gxIntervals:
    left, right = interval

    rect = patches.Rectangle((left, -0.25), step, 0.5, linewidth=1, edgecolor='g', facecolor='g', alpha=0.3)
    plt.gca().add_patch(rect)

plt.ylim(-7, 3)
plt.xlim(1, 20)
plt.plot(gx_x, gx_y, c="black")

plt.show()