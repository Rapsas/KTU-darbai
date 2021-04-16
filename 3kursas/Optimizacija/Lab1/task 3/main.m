x0 = [4,1]; % guess the initial point
options = optimset('LargeScale','off', 'Display', 'iter'); % no LargeScale functions
[x,fval,exitflag,output] = fminunc(@fun,x0,options);
disp("Minimum: " + x);