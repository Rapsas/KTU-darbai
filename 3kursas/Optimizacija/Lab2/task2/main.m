% use meshgrid to create a rectangular grid
[x, y] = meshgrid(-10:1:10, -10:1:10);

% compute function values at the points of the grid
z = x.^2 + y.^2;

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
y1 = -2 - x1;
plot(x1, y1, 'r')

% the next plot will be constructed on top of the existing figure
hold on

% make sure that the grid will stay 10x10
xlim([-10 10])
ylim([-10 10])

% penalty parameter R
r = 0.0000001;

% precision
epsilon = 0.001;

% starting point
xs = [8 8];

% the step size
gamma = 1;

% limit the number of iterations in order to avoid infinite loops
max_iterations = 10000;

for i=1:max_iterations
    
    % gradient of the transformed function
    e1 = 2*xs(1) + 2 * (xs(1) + xs(2) + 2) / r;
    e2 = 2*xs(2) + 2 * (xs(1) + xs(2) + 2) / r;
    grad = [e1 e2];
    
    % compute the next point
    x = xs - gamma*grad;
    
    % plot the step
    plot([xs(1), x(1)], [xs(2), x(2)], 'g', [xs(1), x(1)], [xs(2), x(2)], 'go')
    
    % distance between the previous and current point
    distance = sqrt((x(1) - xs(1))^2 + (x(2) - xs(2))^2);
    
    % refresh the variable
    xs = x;
    
    % update the parameter R
    r = r/1.1;
    
    % Check if the current minimum point did move from the previous minimum
    % point less than epsilon
    if distance < epsilon
        break;
    end
end
