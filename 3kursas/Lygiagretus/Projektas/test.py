from multiprocessing.pool import Pool
from functools import partial
import os

def info(title):
    print(title)
    print('module name:', __name__)
    print('parent process:', os.getppid())
    print('process id:', os.getpid())

def f(name):
    print('hello', name, " PID:", os.getpid())

if __name__ == '__main__':
    with Pool(processes=4) as pool:
        #args = partial(f, ['1', '2', '3', '4'])
        pool.map(f, range(50))