import matplotlib.pyplot as plt
import numpy as np
from matplotlib import cm

X = np.arange(-10, 10, 0.01)
Y = np.arange(-10, 10, 0.01)
XX, YY = np.meshgrid(X, Y)

Z1 = 0.1 * XX**3 - 0.3 * XX * YY**2
Z2 = XX**2 + YY**2 + 5 * np.cos(XX) - 16

figure = plt.figure()
aXis = figure.gca(projection='3d')
surf = aXis.plot_surface(XX, YY, Z1, cmap=cm.coolwarm, alpha=0.5)
surfZ = aXis.plot_surface(XX, YY, np.zeros(np.shape(Z1)), antialiased=False, alpha=0.2)
cp = aXis.contour(X, Y, Z1, levels=0, colors='red')
plt.show()

figure = plt.figure()
aXis = figure.gca(projection='3d')
surf = aXis.plot_surface(XX, YY, Z2, cmap=cm.summer, antialiased=False, alpha=0.5)
surfZ = aXis.plot_surface(XX, YY, np.zeros(np.shape(Z1)), antialiased=False, alpha=0.2)
cp = aXis.contour(X, Y, Z2, levels=0, colors='green')
plt.show()

figure = plt.figure()
aXis = figure.gca()
aXis.grid(color='#C0C0C0', linestyle='-', linewidth=0.5)
cp = aXis.contour(X, Y, Z1, levels=0, colors='red')
cp = aXis.contour(X, Y, Z2, levels=0, colors='green')
plt.show()
