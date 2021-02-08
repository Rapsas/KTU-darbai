import numpy as np


def f1(x1, x2, x3):
    return 2 * x1 + 2 * x2 - 3 * x3 - 32


def f2(x1, x2, x4):
    return x1 * x2 - 2 * x4 - 12


def f3(x2, x3):
    return -4 * x2 ** 2 + x2 * x3 + 3 * x3 ** 3 + 676


def f4(x1, x2, x3, x4):
    return 5 * x1 - 6 * x2 + x3 + 3 * x4 - 4


def f(x1, x2, x3, x4):
    return np.array([[f1(x1, x2, x3)], [f2(x1, x2, x4)], [f3(x2, x3)], [f4(x1, x2, x3, x4)]])


# jakobio matrica
def jacobianMatrix(x1, x2, x3, x4):
    jacobian = np.zeros(shape=(4, 4))

    jacobian[0, 0] = 2
    jacobian[0, 1] = 2
    jacobian[0, 2] = -3
    jacobian[0, 3] = 0

    jacobian[1, 0] = x2
    jacobian[1, 1] = x1
    jacobian[1, 2] = 0
    jacobian[1, 3] = -2

    jacobian[2, 0] = 0
    jacobian[2, 1] = -8 * x2 + x3
    jacobian[2, 2] = x2 + 9 * x3**2
    jacobian[2, 3] = 0

    jacobian[3, 0] = 5
    jacobian[3, 1] = -6
    jacobian[3, 2] = 1
    jacobian[3, 3] = 3

    return jacobian


# tikslo funkcija
def target(x1, x2, x3, x4):
    return np.dot(np.transpose(f(x1, x2, x3, x4)), f(x1, x2, x3, x4)) / 2


# gradientas
def gradient(x1, x2, x3, x4):
    return np.matmul(np.transpose(f(x1, x2, x3, x4)), jacobianMatrix(x1, x2, x3, x4))

#Greiciausio nusileidimo funkcija
def descent(x1, x2, x3, x4, iterationMax, step, eps):
    step0 = step
    for i in range(iterationMax):
        g = gradient(x1, x2, x3, x4)
        value = target(x1, x2, x3, x4)
        for j in range(50):
            n = np.linalg.norm(g)
            diferentialx = g / n * step
            x1 = x1 - diferentialx[0][0]
            x2 = x2 - diferentialx[0][1]
            x3 = x3 - diferentialx[0][2]
            x4 = x4 - diferentialx[0][3]
            valueNext = target(x1, x2, x3, x4)

            #Jeigu sekanti funkcijos verte didesne negu esama, griztama atgal ir mazinamas zingsnis
            if valueNext > value:
                x1 = x1 + diferentialx[0][0]
                x2 = x2 + diferentialx[0][1]
                x3 = x3 + diferentialx[0][2]
                x4 = x4 + diferentialx[0][3]
                step = step / 10
            else:
                value = valueNext
        step = step0
        precision = np.linalg.norm(value)
        print("i:%g, x1=%g, x2=%g, x3=%g, x4=%g, prec=%g" % (i + 1, x1, x2, x3, x4, precision))
        if (precision < eps):
            return x1, x2, x3, x4
    return "tikslumas nepasiektas"


print(descent(4.99, 1.99, -5.99, -0.99, 10000, 0.1, 1e-5))
