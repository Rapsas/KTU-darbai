clc
syms x y
f = (1.5 - x + x * y)^2 + (2.25 - x + x * y^2)^2 + (2.625 - x + x * y^3)^2;
%diff(f, x)
%diff(f, y)
pagalx = 2*(y^2 - 1)*(x*y^2 - x + 9/4) + 2*(y^3 - 1)*(x*y^3 - x + 21/8) + 2*(y - 1)*(x*y - x + 3/2);
pagaly = 2*x*(x*y - x + 3/2) + 4*x*y*(x*y^2 - x + 9/4) + 6*x*y^2*(x*y^3 - x + 21/8);
diff(pagalx, x) %xx
diff(pagalx, y) %xy
diff(pagaly, y) %yy
diff(pagaly, x) %yx