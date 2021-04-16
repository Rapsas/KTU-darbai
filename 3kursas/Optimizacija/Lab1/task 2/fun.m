% use meshgrid to create a rectangular grid
[x,y]=meshgrid(-2:.2:2,-1.8:.2:1.8);
% compute function values at the points of the grid

%z = x.^2 + 100 * y.^2;
%z = 100 * (y - x.^2).^2 + (1-x).^2;
%z = sin(x.^2 + 3*y.^2 + 1) ./ (x.^2 + 3*y.^2 + 1);
z=x.*exp(-x.^2-y.^2);

% compute gradients
% dx – partial derivative in respect of x; dy – partial derivative in respect of y
[dx,dy]=gradient(z);
% plot contourlines
contour(x,y,z)
% the next plot will be constructed on top of the existing figure
hold on
% plot gradients
quiver(x,y,dx,dy)
% finish drawing
hold off