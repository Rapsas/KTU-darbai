import numpy as np
import matplotlib.pyplot as plt


def euler_method(T1, TA1, ts, TA2, tmax, t0, dt):

    print("Euler method calculating...")

    x_over_time = [t0]
    y_subject_temp = [T1]
    y_env_temp = [TA1]
    TA = TA1
    T = T1
    margin = 1e-2
    subject_env_temp_is_equal = False

    for t in np.arange(t0, tmax, dt):

        # Praėjus duotam laikui temperatūros kitimo dėsnis keičiamas į TA(t)
        if t >= ts and np.abs(TA - TA2) > margin:
            TA = TA1 + (TA2 - TA1) / 2 * (1 - np.cos(np.pi / 20 * (t - ts)))

        # Eulerio formule. 18 skaidre
        k = get_k(T)
        dTdt = k * (T - TA)
        T = T + dt * dTdt

        if np.abs(T - TA) < margin and not subject_env_temp_is_equal:
            print(f"Kūno ir aplinkos temperatūros tapo vienodos praėjus: {t}s, temperatūra = {T}T")
            subject_env_temp_is_equal = True
            plt.scatter(t, T, color="red", zorder=3, label='Kūno temperatūra pasiekia aplinkos temperatūrą')

        x_over_time.append(t)
        y_subject_temp.append(T)
        y_env_temp.append(TA)

    plt.plot(x_over_time, y_subject_temp, zorder=1, label='Kūno temperatūra')
    plt.plot(x_over_time, y_env_temp, zorder=2, label='Aplinkos temperatūra')
    plt.xlabel('Laikas, s')
    plt.ylabel('Temperatūra, K')
    plt.title(f"Uždavinys variantams 16-20, žingsnis: {dt}")
    plt.legend()
    plt.show()


def get_k(T):

    return -0.01 - 0.16 * (T - 273) / 100 - 0.04 * ((T - 273) / 100) ** 2


def runge_kutta_method(T1, TA1, ts, TA2, tmax, t0, dt):

    print("Runge-Kutta method calculating...")

    x_over_time = [t0]
    y_subject_temp = [T1]
    y_env_temp = [TA1]
    TA = TA1
    T = T1
    margin = 1e-2
    subject_env_temp_is_equal = False

    for t in np.arange(t0, tmax, dt):

        # Praėjus duotam laikui temperatūros kitimo dėsnis keičiamas į TA(t)
        if t >= ts and np.abs(TA - TA2) > margin:
            TA = TA1 + (TA2 - TA1) / 2 * (1 - np.cos(np.pi / 20 * (t - ts)))

        k = get_k(T)
        dTdt = k * (T - TA)
        f1 = dTdt

        # Pirmas Runge skaiciavimo etapas 
        T1 = T + dt / 2 * f1
        k = get_k(T1)
        dTdt = k * (T1 - TA)
        f2 = dTdt

        # Antras Runge skaiciavimo etapas 
        T2 = T + dt / 2 * f2
        k = get_k(T2)
        dTdt = k * (T2 - TA)
        f3 = dTdt

        # Trecias Runge skaiciavimo etapas 
        T3 = T + dt * f3
        k = get_k(T3)
        dTdt = k * (T3 - TA)
        f4 = dTdt

        # Apjungimas. 30 skaidre
        T = T + dt / 6 * (f1 + 2 * f2 + 2 * f3 + f4)

        if np.abs(T - TA) < margin and not subject_env_temp_is_equal:
            print(f"Kūno ir aplinkos temperatūros tapo vienodos praėjus: {t}s, temperatūra = {T}T")
            subject_env_temp_is_equal = True
            plt.scatter(t, T, color="red", zorder=3, label='Kūno temperatūra pasiekia aplinkos temperatūrą')

        x_over_time.append(t)
        y_subject_temp.append(T)
        y_env_temp.append(TA)

    plt.plot(x_over_time, y_subject_temp, zorder=1, label='Kūno temperatūra')
    plt.plot(x_over_time, y_env_temp, zorder=2, label='Aplinkos temperatūra')
    plt.xlabel('Laikas, s')
    plt.ylabel('Temperatūra, K')
    plt.title(f"Uždavinys variantams 16-20, žingsnis: {dt}")
    plt.legend()
    plt.show()


if __name__ == '__main__':

    # Duoto kūno pradinė temperatūra, Kelvinai
    T1 = 400
    # Aplinkos temperatūra, K
    TA1 = 320
    # Laikas, po kurio temperatūros kitimo dėsnis keičiasi į TA(t) s
    ts = 30
    # Temperatūra, kai aplinkos nustojo kaisti, Kelvinai
    TA2 = 460
    # Kitimo sistemos galutinis laiko momentas, s
    tmax = 80
    # Antro varianto kūno temperatūra, Kelvinai
    T2 = 270
    # Pradinis laiko momentas, s
    t0 = 0
    # Laiko kitimo žingsnis, s
    dt = 0.1

    euler_method(T1, TA1, ts, TA2, tmax, t0, dt)
    # euler_method(T2, TA1, ts, TA2, tmax, t0, dt)

    # runge_kutta_method(T1, TA1, ts, TA2, tmax, t0, dt)
    # runge_kutta_method(T2, TA1, ts, TA2, tmax, t0, dt)
