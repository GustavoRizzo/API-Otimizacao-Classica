# API-Otimizacao-Classica
API-Otimizacao-Classica desenvolvida em dotnet core, tem como objetivo oferecer mátodos de otimização classicos

dotnet restore               
dotnet run               
http://localhost:5010/api/values

teste passar uma função e um valor de coordenada e receba a imagem da função, ex:               
http://localhost:5010/api/values/x+1/1               
Retorno: ["f(x) = 2","x = 1"]               
Ou então               
http://localhost:5010/api/values/0.65-(0.75div(1+x^2))-0.65*x*atan(1divx)/1               
Retorno: ["f(x) = -0,235508806208341","x = 1"]               
