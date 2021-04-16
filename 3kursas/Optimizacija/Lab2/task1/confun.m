function [c, ceq] = confun(x)

c = [x(1) - x(2); x(1)^2 + x(2)^2 - 1.5];

% since equality constraints are missing:
ceq = [];
