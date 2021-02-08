import numpy as np
import random
from matplotlib import pyplot as plt
import networkx as nx

#vidutinis atstumas visu tasku
def averageDistance(x, y):
    n = len(x)
    distance = 0

    for i in range(0, n - 1):
        for j in range(i + 1, n):
            distance += np.sqrt(((x[j] - x[i]) ** 2 + (y[j] - y[i]) ** 2))

    return distance / (n * (n - 1) / 2)

#Tikslo funkcija, kurios reiksme turesim minimizuoti
def targetFunction(x, y, identitie, d, s):
    target = 0.0
    dynamicPoints = []
    n = len(x)

    for i in range(0, n):
        if identitie[i] == 0:
            dynamicPoints.append([x[i], y[i]])

    m = len(dynamicPoints)

    for i in range(0, m):
        for j in range(0, n):
            if i + m != j:
                target += (np.sqrt((x[j] - x[i]) ** 2 + (y[j] - y[i]) ** 2) - d) ** 2
        target += (np.sqrt((dynamicPoints[i][0]) ** 2 + (dynamicPoints[i][1]) ** 2) - s) ** 2

    return target

#Gradiento funkcija
def gradient(x, y, identify, d, s):
    h = 0.0001
    n = x.shape[0]
    xGradient = np.zeros(n)
    yGradient = np.zeros(n)
    value = targetFunction(x, y, identify, d, s)

    for i in range(0, n):
        xxx = np.array(x, copy=True)
        xxx[i] += h
        valueNextX = targetFunction(xxx, y, identify, d, s)
        xGradient[i] = (valueNextX - value) / h

    for i in range(0, n):
        yyy = np.array(y, copy=True)
        yyy[i] += h
        valueNextY = targetFunction(x, yyy, identify, d, s)
        yGradient[i] = (valueNextY - value) / h

    s = ([xGradient, yGradient])

    return s


def drawGraph(x, y, identify):
    n = x.shape[0]
    pos = {}

    for i in range(0, n):
        pos[i] = ([x[i], y[i]])

    graph = nx.complete_graph(x.shape[0])
    color = ["" for i in range(0, x.shape[0])]

    for i in range(0, x.shape[0]):
        if identify[i] == 0:
            color[i] = 'Green'
        else:
            color[i] = 'Red'

    nx.draw_networkx(graph, pos, linewidths=0.5, node_color=color)
    plt.xlim(-12, 12)
    plt.ylim(-12, 12)
    plt.tick_params(left=True, bottom=True, labelleft=True, labelbottom=True)
    plt.show()


def main():
    random.seed(69666)
    n = 8
    x = np.array(random.sample(range(-10, 10), n))
    print("x:\n", x)
    y = np.array(random.sample(range(-10, 10), n))
    print("y:\n", y)
    identify = np.array([0, 0, 1, 1, 0, 1, 1, 0])
    s = 1

    d = averageDistance(x, y)
    print("vidutinis atstumas:", d)

    f = targetFunction(x, y, identify, d, s)

    step0 = 0.1
    step = step0
    maxIterations = 1000

    targetValues = []
    iterations = []

    drawGraph(x, y, identify)

    for i in range(0, maxIterations):
        grad = gradient(x, y, identify, d, s) * identify
        fff_initial = targetFunction(x, y, identify, d, s)
        derivative = grad / np.linalg.norm(grad) * step
        x = x - derivative[0].transpose()
        y = y - derivative[1].transpose()
        fff_after = targetFunction(x, y, identify, d, s)

        if fff_after > fff_initial:
            x = x + derivative[0].transpose()
            y = y + derivative[1].transpose()
            step /= 2

        precision = np.abs(fff_initial - fff_after) / (np.abs(fff_initial) + np.abs(fff_after))
        # print("f = {}".format(fff_after))
        if precision < 1e-16:
            print("Rezultatas x:\n", x)
            print("Rezultatas y:\n", y)
            break
        elif i == maxIterations:
            print("Tikslumas nepasiektas. Paskutinis artinys x = {}".format(x))
            break

        targetValues.append(fff_initial)
        iterations.append(i)

    drawGraph(x, y, identify)

    plt.plot(iterations, targetValues, 'b-')
    plt.title("Tikslo f-jos priklausomybe nuo iteraciju")
    plt.xlabel('Iteracijos')
    plt.ylabel('Tikslo f-ja')
    plt.show()



main()
