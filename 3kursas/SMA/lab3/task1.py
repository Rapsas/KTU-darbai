from matplotlib import pyplot as plt
import numpy as np


def f(x):
    return np.cos(2 * x) / (np.sin(2 * x) + 1.5) - x / 5


def chebyshev_interpolation(x, coef):
    T = np.zeros(len(coef))
    xAmendent = (2 * x) / (b - a) - (b + a) / (b - a)
    T[0] = 1
    T[1] = xAmendent

    # Čiobyševo interpoliavimo matricos sudarymas
    for i in range(2, n):
        T[i] = 2 * xAmendent * T[i - 1] - T[i - 2]

    # Dauginame koeficientus su Čiobyševo interpoliavimo matrica, gauname atsakymus
    y = np.dot(T, coef)
    return y


def target_fx_points(start, finnish, step):
    x = []
    y = []
    it = start

    while it <= finnish:
        x.append(it)
        y.append(f(it))
        it = it + step

    return x, y


def chebyshev_interpolation_points(start, finnish, step, coef):
    x = []
    y = []
    it = start

    while it <= finnish:
        x.append(it)
        y.append(chebyshev_interpolation(it, coef))
        it = it + step

    return x, y


if __name__ == "__main__":

    # pasirenkamem, kurią užduoties dalį norime vykdyti
    first = False

    # laisvai pasitinktas interpoliavimo taškų kiekis
    n = 15

    # funkcijos intervalas kuria interpoliuosime
    a = -2
    b = 3

    # x taškai
    x = []

    # taškai pasiskirstę tolygiai
    if first:
        x = np.linspace(a, b, n, endpoint=True)
    # taškai apskaičiuojami naudojant Čiobyševo abscises
    else:
        for i in range(n):
            # Kadangi skaičiuojame ne intervale  [-1, 1] tai reikalinga x'ui apskaičiuoti keitinį
            xAmendment = ((b - a) / 2) * np.cos((np.pi * (2 * i + 1)) / (2 * n)) + (b + a) / 2
            x.append(xAmendment)

    # y taškai
    y = []

    for i in range(n):
        y.append(f(x[i]))

    T = np.zeros((n, n))

    # randa funkcijos x reikšmes
    for i in range(n):
        T[i, 0] = 1
        xAmendment = (2 * x[i]) / (b - a) - (b + a) / (b - a)
        T[i, 1] = xAmendment
        for j in range(2, n):
            T[i, j] = 2 * xAmendment * T[i, j - 1] - T[i, j - 2]

    # Kadangi žimone kokias vertes y'as turi turėti, galime apsiskaičiuoti Čiobyševo koeficientus
    coef = np.linalg.solve(T, y)
    print("Koeficientai:\n", coef)

    # randa funkcijos analitinius taškus
    fx, fy = target_fx_points(a, b, 0.01)

    # randa interpoliuotos funkcijos taškus
    ix, iy = chebyshev_interpolation_points(a, b, 0.01, coef)

    # piešia grafiką
    plt.title('Duota funkcija f(x): cos(2*x)/(sin(2*x)+1.5) - x/5')
    plt.plot(fx, fy, label='Funkcija f(x)')
    plt.plot(ix, iy, label='Interpoliuota funkcija f(x)', color="green", linestyle='dashed')
    plt.fill_between(fx, fy, iy, color="orange", label="Netiktis")
    plt.scatter(x, y, label='Funkcijos f(x) taškai')
    plt.xlabel('x')
    plt.ylabel('f(x)')
    plt.legend()
    plt.grid(0.5)
    plt.show()
