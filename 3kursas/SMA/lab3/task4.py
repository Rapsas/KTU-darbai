import numpy as np
from matplotlib import pyplot as plt
import calendar

# finds base function matrix
def calculate_base(X, m):
    n = len(X)
    T = np.zeros([n, m])
    for i in range(n):
        for j in range(m):
            T[i, j] = X[i] ** j

    return T

# G^T*G . G^T*y
def calculate_coefficients(G, y):
    a = np.matmul(np.transpose(G), G)
    b = np.matmul(np.transpose(G), y)
    c = np.linalg.solve(a, b)

    return c


if __name__ == "__main__":
    # order of polynomial approximation
    m = 1
    X = np.arange(1, 13)
    # temperatures
    Y = np.array([
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

    # get base function matrix
    baz = calculate_base(X, m)
    # calculate base coefficients
    c = calculate_coefficients(baz, Y)

    nn = 50 # render points
    # spline x range
    xx = np.linspace(1, 12, nn)

    # set x range for Gc
    Gc = calculate_base(xx, m)
    # calculate Gc
    fff = np.matmul(Gc, c)
    print(c)

    plt.title('%dth order polynomial' % m)
    plt.plot(xx, fff, label='f(x) temp. aproximated')
    plt.scatter(X, Y, label='month temp. points')
    plt.xlabel("month")
    plt.xticks(X, calendar.month_name[1:13])
    plt.ylabel('temp, C')
    plt.legend()
    plt.grid(1)
    plt.show()
