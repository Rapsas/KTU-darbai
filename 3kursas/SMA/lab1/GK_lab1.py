import numpy as np
import matplotlib.pyplot as plt
import matplotlib.patches as patches
import sympy

sx = sympy.Symbol('x')
MAX_ITER = 40


# Pirma funkcija
def fx(ax):
    return 1.03*ax**5 - 2.91*ax**4 - 1.44*ax**3 + 5.56*ax**2 - 0.36*ax - 1.13


# Pirmos funkcijos išvestinė
fxD = sympy.lambdify(sx, (1.03*sx**5 - 2.91*sx**4 - 1.44*sx**3 + 5.56*sx**2 - 0.36*sx - 1.13).diff(), 'numpy')


# Antra funkcija
def gx(ax):
    return np.sin(ax) * np.log(ax) - ax/6


# Antros funkcijos išvestinė
gxD = sympy.lambdify(sx, (sympy.sin(sx) * sympy.log(sx) - sx/6).diff(), 'numpy')


# Stygu
def chord(func, xFrom, xTo, precision):
    xl = xFrom
    xr = xTo

    it = 0

    while True:
        it += 1

        k = abs(func(xl)/func(xr))
        xmid = (xl + k * xr) / (1 + k)

        if np.sign(func(xmid)) == np.sign(func(xl)):
            xl = xmid
        else:
            xr = xmid

        if abs(func(xmid)) < precision:
            return xmid, it


# Niutono (liestiniu)
def newton(func, funcD, xFrom, xTo, precision):
    # Pradinis artinys
    xo = xFrom

    it = 0

    # Kadangi Niutono gali nekonverguoti
    for i in range(0, MAX_ITER):
        it += 1

        fxv = func(xo)
        fxdv = funcD(xo)

        if abs(fxv) < precision:
            return xo, it

        if fxdv == 0:
            return xo, it

        xo = xo - fxv/fxdv

    return None, it


# Skenavimo su mazejanciu zingsniu
def scan_varied(func, step, xFrom, xTo, precision):
    # Vykdoma tol kol intervalas bus daugiau negu precision
    width = step

    xl = xFrom
    xr = xFrom + width

    it = 0

    while width > precision:
        it += 1

        flv = func(xl)
        frv = func(xr)

        if np.sign(flv) == np.sign(frv):
            # Šaknis ne intervale
            xl = xr
            xr = xr + width
        else:
            # Sumažinamas žingsnis ir perskaičiuojamas dešinys taškas
            width = width / 4
            xr = xl + width

    return xl, it


# Skenavimas su nekintanciu zingsniu
def scan_fixed(func, xFrom, xTo, step):
    # Taskai kuriuos tikrinsim
    c_x = xFrom

    # Intervalai
    intervals = []

    # Skenuojama
    while c_x <= xTo:
        left_check = c_x
        right_check = c_x + step
        c_x += step

        if np.sign(func(left_check)) != np.sign(func(right_check)):
            # Saknies intervalas
            intervals.append((left_check, right_check))

    return intervals


# Intervalai
R = 1 + 5.56/1.03

B_teig = 2.91
k_teig = 5 - 4
R_teig = 1 + (B_teig / 1.03) ** (1/k_teig)

B_neig = 5.56
k_neig = 5 - 3
R_neig = 1 + (B_neig / 1.03) ** (1/k_neig)

tl = min([R_neig, R]) * -1
tr = min([R_teig, R])

print(f"Grubus intervalas: ({R * -1}; {R})")
print(f"Tikslus intervalas: ({tl}; {tr})")

# Scan with fixed step size
fx_step = 0.1
gx_step = 0.1

intervals_fx = scan_fixed(fx, tl, tr, fx_step)
intervals_gx = scan_fixed(gx, 1, 20, gx_step)

print("f(x) intervalai:", intervals_fx)
print("g(x) intervalai:", intervals_gx)

# Scan with provided methods
p = 0.0000001

chord_roots = []
chord_it = []

newton_roots = []
newton_it = []

scan_roots = []
scan_it = []

for interval in intervals_fx:
    left, right = interval

    c_root, c_it = chord(fx, left, right, p)
    chord_roots.append(c_root)
    chord_it.append(c_it)

    n_root, n_it = newton(fx, fxD, left, right, p)
    newton_roots.append(n_root)
    newton_it.append(n_it)

    s_root, s_it = scan_varied(fx, fx_step / 2, left, right, p)
    scan_roots.append(s_root)
    scan_it.append(s_it)


print("    Numpy šaknys f(x):", sorted(np.roots([1.03, -2.91, -1.44, 5.56, -0.36, -1.13])))
print("    Stygų šaknys f(x):", chord_roots)
print("  Niutono šaknys f(x):", newton_roots)
print("Skenavimo šaknys f(x):", scan_roots)

print("    Stygų šaknų iteracijos f(x):", chord_it)
print("  Niutono šaknų iteracijos f(x):", newton_it)
print("Skenavimo šaknų iteracijos f(x):", scan_it)

chord_roots = []
chord_it = []

newton_roots = []
newton_it = []

scan_roots = []
scan_it = []

for interval in intervals_gx:
    left, right = interval

    c_root, c_it = chord(gx, left, right, p)
    chord_roots.append(c_root)
    chord_it.append(c_it)

    n_root, n_it = newton(gx, gxD, left, right, p)
    newton_roots.append(n_root)
    newton_it.append(n_it)

    s_root, s_it = scan_varied(gx, gx_step / 2, left, right, p)
    scan_roots.append(s_root)
    scan_it.append(s_it)

print("\n")
print("    Stygų šaknys g(x):", chord_roots)
print("  Niutono šaknys g(x):", newton_roots)
print("Skenavimo šaknys g(x):", scan_roots)

print("    Stygų šaknų iteracijos g(x):", chord_it)
print("  Niutono šaknų iteracijos g(x):", newton_it)
print("Skenavimo šaknų iteracijos g(x):", scan_it)

# Generate data
gx_x = np.linspace(1, 20, 500)
gx_y = np.apply_along_axis(gx, 0, gx_x)

fx_x = np.linspace(tl, tr, 500)
fx_y = np.apply_along_axis(fx, 0, fx_x)

# Plot graphs
plt.figure(figsize=(15, 5))

plt.subplot(1, 2, 1)
plt.gca().set_title("f(x)")
plt.axhline(0)
plt.axvline(0)

plt.plot([tl, tl], [-5, 5], linestyle="dashed", c="red")
plt.plot([tr, tr], [-5, 5], linestyle="dashed", c="red")

# Intervals
for interval in intervals_fx:
    left, right = interval

    rect = patches.Rectangle((left, -0.5), fx_step, 1, linewidth=1, edgecolor='r', facecolor='r', alpha=0.3)
    plt.gca().add_patch(rect)

plt.ylim(-6, 6)
plt.plot(fx_x, fx_y, c="black")

plt.subplot(1, 2, 2)
plt.gca().set_title("g(x)")
plt.axhline(0)
plt.axvline(0)

# Intervals
for interval in intervals_gx:
    left, right = interval

    rect = patches.Rectangle((left, -0.5), gx_step, 1, linewidth=1, edgecolor='r', facecolor='r', alpha=0.3)
    plt.gca().add_patch(rect)


plt.ylim(-10, 10)
plt.plot(gx_x, gx_y, c="black")

# Show graph
plt.show()