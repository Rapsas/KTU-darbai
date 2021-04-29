function h = hessian(x, y)
xx = (y^2 - 1)*(2*y^2 - 2) + (y^3 - 1)*(2*y^3 - 2) + (2*y - 2)*(y - 1);
xy = x*(2*y - 2) - 2*x + 6*y^2*(x*y^3 - x + 21/8) + 2*x*y + 4*y*(x*y^2 - x + 9/4) + 3*x*y^2*(2*y^3 - 2) + 2*x*y*(2*y^2 - 2) + 3;
yy = 8*x^2*y^2 + 18*x^2*y^4 + 4*x*(x*y^2 - x + 9/4) + 2*x^2 + 12*x*y*(x*y^3 - x + 21/8);
yx = 6*y^2*(x*y^3 - x + 21/8) - 2*x + 2*x*y + 2*x*(y - 1) + 4*y*(x*y^2 - x + 9/4) + 4*x*y*(y^2 - 1) + 6*x*y^2*(y^3 - 1) + 3;
h = [xx xy;
     yx yy];