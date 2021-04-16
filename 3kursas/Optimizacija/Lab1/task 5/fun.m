% Plot the trajectory of Anti-Gradient Descent
[x,y]=meshgrid(-5:.5:5);
z = (1.5 - x + x.*y).^2 + (2.25 - x + x.*y.^2).^2 + (2.625 - x + x.*y.^3).^2;
figure(1)
hold off
contour(x,y,z)
[dx,dy]=gradient(z,.2,.2);
hold on
quiver(x,y,dx,dy)
% set the initial point
x=[3,1];
xs=x; % dummy variable required for the iterative process
itsk=2500; % the number of iterations
step=0.001; % the step size
for i=1:itsk

 % compute the next point
 x = xs - step*gradient1(xs(1), xs(2))/gradientLength(xs(1), xs(2));
 % plot the step
 plot([xs(1),x(1)],[xs(2),x(2)],'r',[xs(1),x(1)],[xs(2),x(2)],'ro')
 % refresh the variables
 xs=x;
 %disp(xs);
end
