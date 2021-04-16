% use meshgrid to create a rectangular grid
[x, y] = meshgrid(-10:.1:10, -10:.1:10);

% compute function values at the points of the grid
z = (1.5 - x + x.* y).^2 + (2.25 - x + x.* y.^2).^2 + (2.625 - x + x.* y.^3).^2;

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
x1 = -10:.1:10;
y1 = x1;
plot(x1, y1, 'r')

% the next plot will be constructed on top of the existing figure
hold on

% plot the constraints functions g2 positive values
x2 = -sqrt(1.5):.00001:sqrt(1.5);
y2 = sqrt(1.5 - x2.^2);
plot(x2, y2, 'g')

% the next plot will be constructed on top of the existing figure
hold on

% plot the constraints functions g2 negative values
plot(x2, -y2, 'g')

% make sure that the grid will stay 10x10
xlim([-10 10])
ylim([-10 10])

% make an initial guess:
x0 = [-1 1];

% Setup the optimization parameters:
% turn off large-scale algorithms
% turn on Display options for visualization of transient results
options = optimset('LargeScale', 'off', 'Display', 'iter');

% non-explicit constraints are replaced by []
[x, fval, exitflag, output] = fmincon('objfun', x0, [], [], [], [], [], [], 'confun', options);

% the next plot will be constructed on top of the existing figure
hold on

% plot the result X point
plot(x(1), x(2), 'm*')

% finish drawing
hold off

disp(x)
disp(fval)
disp(exitflag)
disp(output.message)
