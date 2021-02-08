from matplotlib import pyplot as plt
import numpy as np
import calendar


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

    # interpoliavimo taškų skaičius
    n = len(y)

    # x taškai
    x = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]

    a = 1
    b = 12

    T = np.zeros((n, n))

    # randa funkcijos x reikšmes
    for i in range(n):
        T[i, 0] = 1
        xAmendment = (2 * x[i]) / (b - a) - (b + a) / (b - a)
        T[i, 1] = xAmendment
        for j in range(2, n):
            T[i, j] = 2 * xAmendment * T[i, j - 1] - T[i, j - 2]

    # randa koeficientus
    coef = np.linalg.solve(T, y)
    print("Koeficientai:\n", coef)


    # randa interpoliuotos funkcijos taškus
    ix, iy = chebyshev_interpolation_points(1, 12, 0.01, coef)

    # piešia grafiką
    plt.plot(x, y, label='Funkcija f(x)')
    plt.plot(ix, iy, label='Interpoliuota funkcija f(x)', color="red", linestyle='dashed')
    plt.scatter(x, y, label='Funkcijos f(x) taškai')
    plt.title("Austria 2014 monthly temperatures\nPolynomial interpolation")
    plt.xlabel('Month')
    plt.ylabel('Average month temperature in C')
    plt.xticks(x, calendar.month_name[1:13])
    plt.legend()
    plt.grid(0.5)
    plt.show()
