syms x y
f = (1.5 - x + x * y)^2 + (2.25 - x + x * y^2)^2 + (2.625 - x + x * y^3)^2;
fx = diff(f, x)
fy = diff(f, y)

g1 = x - y;
g2 = x^2 + y^2 - 1.5;

g1x = diff(g1, x)
g1y = diff(g1, y)

g2x = diff(g2, x)
g2y = diff(g2, y)

xs = -0.4036;
ys = 1.1563;

% fx(xs, ys)
% fy(xs, ys)
% 
% g1x(xs, ys)
% g1y(xs, ys)
% 
% g2x(xs, ys)
% g2y(xs, ys)

% function z = bazinga(x, y)

disp(2*(ys^2 - 1)*(xs*ys^2 - xs + 9/4) + 2*(ys^3 - 1)*(xs*ys^3 - xs + 21/8) + 2*(ys - 1)*(xs*ys - xs + 3/2))
disp(2*xs*(xs*ys - xs + 3/2) + 4*xs*ys*(xs*ys^2 - xs + 9/4) + 6*xs*ys^2*(xs*ys^3 - xs + 21/8))

disp(2*xs)
disp(2*ys)