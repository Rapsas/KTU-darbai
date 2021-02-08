import numpy as np

def f(x):
    return x**2

suma = 0
xx = 5 

for i in range(83):
    suma = suma + f(xx)
    xx = xx + 0.3
    print(i)

print(4 * np.pi * suma)