% plot function g1
x = 0.55:0.001:8;
g1 = sqrt(2.*x - 1.1);
plot(x, g1, 'r')
hold on
plot(x, -g1, 'r')
hold on

% plot fuction g2
x = -8:0.001:8;
g2 = (9.1 - 0.8.*x.^2)/2;
plot(x, g2, 'b')
hold on

% make sure that the grid will stay at a fixed size
xlim([0 5])
ylim([-4 4])

x0 = [1.05 -1];
f = [-1; 0; 0];
lb = [-1; -1; -1];
ub = [1000; 1; 1];

% limit the number of iterations in order to avoid infinite loops
max_iterations = 10000;

% track which constraint is currently active
firstConstraintActive = true;

% store the previous x value
x_prev = x0;

% precision
epsilon = 0.001;

for i=1:max_iterations
    
    % calculate and plot the gradient of function f
    grad_f = [2*(x0(1)-4) 2*(x0(2)-4)];
    quiver(x0(1), x0(2), grad_f(1)/norm(grad_f), grad_f(2)/norm(grad_f))
    hold on
    
    % calculate the gradient and value of function g1
    grad_g1 = [2 -2*x0(2)];
    g1 = 2*x0(1) - x0(2)^2 - 1.1;
    
    % calculate the gradient and value of function g2
    grad_g2 = [-1.6*x0(1) -2];
    g2 = 9 - 0.8*x0(1)^2 - 2*x0(2);
    
    % plot the gradient of function g1
    quiver(x0(1), x0(2), grad_g1(1)/norm(grad_g1), grad_g1(2)/norm(grad_g1))
    hold on
    
    % plot the gradient of function g2
    quiver(x0(1), x0(2), grad_g2(1)/norm(grad_g2), grad_g2(2)/norm(grad_g2))
    hold on
    
    b = [0 g1 g2];
    A = [1 grad_f(1) grad_f(2); 1 -grad_g1(1) -grad_g1(2); 1 -grad_g2(1) -grad_g2(2)];
    [x, fval, exitflag] = linprog(f, A, b, [], [], lb, ub);
    
    % get and plot the direction vector
    d = [x(2), x(3)];
    quiver(x0(1), x0(2), d(1)/norm(d), d(2)/norm(d))
    
    for j=1:max_iterations
        g = 9 - 0.8*x0(1)^2 - 2*x0(2);
        
        % check which boundary is active
        if ~firstConstraintActive
            g = 2*x0(1) - x0(2)^2 - 1.1;
        end
        
        % break if boundary reached
        if g >= 0
            x = x0 + 0.01*d;
            plot([x0(1), x(1)], [x0(2), x(2)], 'g', [x0(1), x(1)], [x0(2), x(2)], 'go')
            x0 = x;
        else
            break;
        end
    end
    
    % make the other constraint active
    firstConstraintActive = ~firstConstraintActive;
    
    % check the distance between the current and previous points
    distance = sqrt((x0(1) - x_prev(1))^2 + (x0(2) - x_prev(2))^2);
    
    % make sure that at least the algorithm worked 5 times
    if distance < epsilon && i > 5
        break;
    end
    
    % refresh the current point
    x_prev = x0;
end
