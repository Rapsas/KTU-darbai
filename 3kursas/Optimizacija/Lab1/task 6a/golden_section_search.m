function gamma = golden_section_search(xs, s)

a=0;                            % start of interval
b=1;                            % end of interval
epsilon=0.000001;               % accuracy value
iter= 50;                       % maximum number of iterations
tau=double((sqrt(5)-1)/2);      % golden proportion coefficient, around 0.618
k=0;                            % number of iterations

x1=a+(1-tau)*(b-a);             % computing x values
x2=a+tau*(b-a);

f_x1=f_gamma(xs, s, x1);
f_x2=f_gamma(xs, s, x2);

while ((abs(b-a)>epsilon) && (k<iter))
    k=k+1;
    if(f_x1<f_x2)
        b=x2;
        x2=x1;
        x1=a+(1-tau)*(b-a);
        
        f_x1=f_gamma(xs, s, x1);
        f_x2=f_gamma(xs, s, x2);
    else
        a=x1;
        x1=x2;
        x2=a+tau*(b-a);
        
        f_x1=f_gamma(xs, s, x1);
        f_x2=f_gamma(xs, s, x2);
    end
    
    k=k+1;
end
% chooses minimum point
if(f_x1<f_x2)
    gamma = x1;
else
    gamma = x2;
end
