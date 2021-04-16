% Plot the trajectory of conjugate Gradient Descent
[x, y] = meshgrid(-5:.5:5);
z = (1.5 - x + x.*y).^2 + (2.25 - x + x.*y.^2).^2 + (2.625 - x + x.*y.^3).^2;
figure(1)
hold off
contour(x, y, z)
[dx, dy] = gradient(z,.2,.2);
hold on
quiver(x, y, dx, dy)

% set the initial point
x0=[4, 0.8];
xs=x0; % dummy variable required for the iterative process
itsk=50; % the number of iterations

for i=1:itsk
    % calculate gradient
    g = df(xs(1), xs(2));
    
    % calculate gamma/step
    gamma = golden_section_search(xs);
    
    % compute the next point
    x = xs - gamma*g;
    
    % plot the step
    plot([xs(1),x(1)],[xs(2),x(2)],'r',[xs(1),x(1)],[xs(2),x(2)],'ro')
    
    % refresh the variables
    xs=x;
end
