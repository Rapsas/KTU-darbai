function g = gradient1(x, y)

df_dx = 2*(y^2 - 1)*(x*y^2 - x + 9/4) + 2*(y^3 - 1)*(x*y^3 - x + 21/8) + 2*(y - 1)*(x*y - x + 3/2);
df_dy = 2*x*(x*y - x + 3/2) + 4*x*y*(x*y^2 - x + 9/4) + 6*x*y^2*(x*y^3 - x + 21/8);

g = [df_dx, df_dy];