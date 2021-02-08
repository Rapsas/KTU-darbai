import numpy as np


def task1(A, B):
    print("Matrix A\n", A)
    print("Matrix B\n", B)

    n = (np.shape(A))[0]
    m = (np.shape(B))[1]

    A1 = np.hstack((A, B))
    print("Matrix A1\n", A1)

    Q = np.identity(n)
    for i in range(0, n - 1):
        z = np.vstack(A1[i:n, i])
        zMirror = np.zeros(np.shape(z))
        zMirror[0] = np.sign(z[0]) * np.linalg.norm(z)

        omega = (z - zMirror) / np.linalg.norm(z - zMirror)

        iterative_Q = np.identity(n - i) - 2 * omega * omega.transpose()
        A1[i:n, :] = iterative_Q.dot(A1[i:n, :])
        print("Matrix A1\n", A1)

        Q = Q.dot(
            np.vstack(
                (
                    np.hstack((np.identity(i), np.zeros(shape=(i, n - i)))),
                    np.hstack((np.zeros(shape=(n - i, i)), iterative_Q))
                )
            )
        )

    R = Q.transpose() * B
    x = np.zeros(shape=(n, m))
    eps = 1e-10

    for i in range(n - 1, -1, -1):  
        if np.abs(A1[i, i]) < eps and np.abs(A1[i, n]) < eps: #Tikriname singuliaruma
            x[i] = 1
            print("Kintamasis x[{}] gali buti bet koks skaicius. Tegul x[{}] = 1".format(i, i))
        elif np.abs(A1[i, i]) < eps and np.abs(A1[i, n]) > eps:
            print("Sprendiniu aibe tuscia, nes 0 * X != {}".format(A1[i, n]))
            return
        else:
            x[i, :] = (R[i, :] - A1[i, i + 1:n] * x[i + 1:n, :]) / A1[i, i]

    print("A\n", A)
    print("x\n", x)
    print("B\n", B)

    print("Tikrinimas:\n", A * x - B)

#Duoda uzduoties, kai nera sprendiniu
A_nedalinta = [
    [ 1,  2, 1, 0],
    [ 2,  5, 0, 4],
    [14, -8, 4, 1],
    [ 4, 10, 0, 8]
    ]

B_nedalinta = [
    -4,        
    3,
    7,
    2
    ]

#Lygtis su vienu sprendiniu
# A_nedalinta = [
#     [ 2,  1, -1, 2],
#     [ 4,  5, -3, 6],
#     [-2, 5, -2, 6],
#     [ 4, 11, -4, 8]
# ]

# B_nedalinta = [
#      5,
#      9,
#      4,
#      2
# ]

# lygciu sistema, kurioje yra daug sprendiniu
# A = [
#   [2, 5, 1, 2], 
#   [-2, 0, 3, 5], 
#   [1, 0, -1, 1], 
#   [0, 5, 4, 7]
# ]
# B = [
#   14, 
#   10, 
#   4, 
#   24
# ]

A = np.matrix(A_nedalinta).astype(np.float)
B = np.matrix(B_nedalinta).transpose().astype(np.float)

task1(A, B)
