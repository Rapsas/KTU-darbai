% use meshgrid to create a rectangular grid
[x, y] = meshgrid(-10:1:10, -10:1:10);

% compute function values at the points of the grid
z = 2*x.^2 + y.^2;

% compute gradients
% dx – partial derivative in respect of x; dy – partial derivative in respect of y
[dx, dy] = gradient(z);

% plot contourlines
contour(x, y, z)

% the next plot will be constructed on top of the existing figure
hold on

% plot gradients
quiver(x, y, dx, dy)

% the next plot will be constructed on top of the existing figure
hold on

% plot the constraints function g1
x1 = -10:1:10;
y1 = - x1 - 5;
plot(x1, y1, 'r')