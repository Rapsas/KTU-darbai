% Plot the trajectory of Newtons method
[x,y]=meshgrid(-5:.5:5);
z = (1.5 - x + x.*y).^2 + (2.25 - x + x.*y.^2).^2 + (2.625 - x + x.*y.^3).^2;
figure(1)
hold off
contour(x,y,z)
[dx,dy]=gradient(z,.2,.2);
hold on
quiver(x,y,dx,dy)
% set the initial point
x=[3.5,0.8]; 
xs=x; % dummy variable required for the iterative process
itsk=20; % the number of iterations
for i=1:itsk
 
 h = hessian(xs(1), xs(2));
 disp(h)
 % compute the next point
 x = xs - gradient1(xs(1), xs(2)) * inv(h);
 % plot the step
 plot([xs(1),x(1)],[xs(2),x(2)],'r',[xs(1),x(1)],[xs(2),x(2)],'ro')
 % refresh the variables 
 xs=x;
 disp("Iteration: " + i + " Minimum: (" + xs(1) + " ; " + xs(2) + ")")
end