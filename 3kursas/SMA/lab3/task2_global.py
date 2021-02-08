import numpy as np
import calendar
from matplotlib import pyplot as plt

# Apskaičiuojame greta esančių taškų atstumus
def calculateDistance(x):
    n = len(x)
    d = np.zeros(n - 1)

    for i in range(n - 1):
        d[i] = x[i + 1] - x[i]
    return d

# Apskaičiuojame globalaus spline'o matricą
def calculateF(x, y):
    n = len(x)
    # x reikšmės
    T = np.zeros((n, n))
    # koeficientai
    b = np.zeros(n)
    # greta esančių taškų atstumai
    d = calculateDistance(x)

    # 40 skaidrė
    for i in range(n - 2):
        T[i, i] = d[i] / 6
        T[i, i + 1] = (d[i] + d[i + 1]) / 3
        T[i, i + 2] = d[i + 1] / 6

    # 40 skaidrė
    for i in range(n - 2):
        b[i] = ((y[i + 2] - y[i + 1]) / d[i + 1]) - ((y[i + 1] - y[i]) / d[i])

    # 43 skaidrė
    T[n - 2, 0] = d[0] / 3
    T[n - 2, 1] = d[0] / 6
    T[n - 2, n - 2] = d[n - 2] / 6
    T[n - 2, n - 1] = d[n - 2] / 3
    T[n - 1, 0] = 1
    T[n - 1, n - 1] = -1
    b[n - 2] = ((y[1] - y[0]) / d[0]) - ((y[n - 1] - y[n - 2]) / d[n - 2])

    yy = np.linalg.solve(T, b)

    return yy


# skaiciuoja funkcijos reiksme taske, 44 skaidre
def spline(ff1, ff2, s, d, y1, y2):
    a = (ff1 * (s**2 / 2)) - (ff1 * (s**3 / (6*d)))
    b = (ff2 * (s**3 / (6*d))) + (((y2 - y1) / d) * s)
    c = (ff1 * ((d/3) * s)) + (ff2 * ((d/6) * s))

    return a + b - c + y1

# Taškų skaičius
n = 12
aa = 1
x = np.arange(aa, aa+n)
# temperatures
y = np.array([
        0.12371,
        1.3831,
        5.29799,
        8.2207,
        10.1892,
        14.8951,
        16.617,
        14.5986,
        12.6457,
        9.69687,
        5.61371,
        0.02563
    ])

ff = calculateF(x, y)

# 41 skaidrė
ff[0] = 0
ff[n - 1] = 0

# atstumai tarp gretimų taškų
d = calculateDistance(x)
# grafiko paišymo žingsnis -1 laipsnyje
step = 100
xx = []
yy = []
# pradedame nuo sausio mėnesio
x1 = 1

# pradedame ciklą nuo antro taško
for i in range(1, n):
    # x2 šiuo atveju bus pradžios taškas (kairysis taškas)
    x2 = x1
    for j in range(step):
        # s yra ilgis, kuris nurodo per kiek esamas taškas yra nutolęs nuo kairiojo (pradinio) taško
        s = x2 - i
        xx.append(x2)
        value = spline(ff[i - 1], ff[i], s, d[i - 1], y[i - 1], y[i])
        yy.append(value)
        # didiname x kas 0.01
        x2 += 1 / step
    x1 += 1

plt.plot(xx, yy, label="Funkcija f(x)")
plt.scatter(x, y, label="Funkcijos f(x) taškai")
plt.xlabel("Month")
plt.ylabel("Average month temperature in C")
plt.legend()
plt.grid()
plt.xticks(x, calendar.month_name[1:13])
plt.title("Austria 2014 monthly temperatures\nGlobal spline")
plt.grid(0.5)
plt.show()
