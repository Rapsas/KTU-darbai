import numpy as np


def f1(x1, x2):
    return 0.1 * x1 ** 3 - 0.3 * x1 * x2 ** 2


def f2(x1, x2):
    return x1 ** 2 + x2 ** 2 + 5 * np.cos(x1) - 16


def f(x1, x2):
    return np.array([[f1(x1, x2)], [f2(x1, x2)]])


# jakobio matrica
def jacobianMatrix(x1, x2):
    jacobian = np.zeros(shape=(2, 2))
    jacobian[0, 0] = 0.3 * x1 ** 2 - 0.3 * x2 ** 2
    jacobian[0, 1] = -0.6 * x1 * x2
    jacobian[1, 0] = 2 * x1 - 5 * np.sin(x1)
    jacobian[1, 1] = 2 * x2

    return jacobian


# tikslo funkcija
def target(x1, x2):
    return np.dot(np.transpose(f(x1, x2)), f(x1, x2)) / 2


# gradientas
def gradient(x1, x2):
    return np.matmul(np.transpose(f(x1, x2)), jacobianMatrix(x1, x2))

#Greiciausio nusileidimo funkcija
def descent(x1, x2, iterationMax, step, eps):
    step0 = step
    for i in range(iterationMax):
        g = gradient(x1, x2)
        value = target(x1, x2)
        for j in range(30):
            n = np.linalg.norm(g)
            diferentialx = g / n * step
            x1 = (x1 - diferentialx[0][0])
            x2 = (x2 - diferentialx[0][1])

            valueNext = target(x1, x2)
            if valueNext > value: #Jeigu sekanti funkcijos verte didesne negu esama, griztama atgal ir mazinamas zingsnis
                x1 = x1 + diferentialx[0][0]
                x2 = x2 + diferentialx[0][1]
                step = step / 10

            else:
                value = valueNext
        step = step0
        precision = np.linalg.norm(value)
        print("i:%g, x1=%g, x2=%g, precision=%g" % (i + 1, x1, x2, precision))
        if precision < eps:
            return x1, x2

    return "tikslumas nepasiektas"

# print(descent(-4, 2, 50, 0.01, 1e-8))
# print(descent(-3.9, -2.1, 50, 0.01, 1e-8))
# print(descent(0.1, 3, 50, 0.01, 1e-8))
print(descent(-0.1, -3, 50, 0.01, 1e-8))

