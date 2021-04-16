function z = f_gamma(x0, gamma)

x = x0 - gamma*df(x0(1), x0(2));

z = f(x(1), x(2));
