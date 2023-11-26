dotnet new --install bunit.template::1.9.8

k create namespace bethany

kubectl create secret generic dbconnectivity --namespace=bethany --from-literal=DefaultConnection='Server=mssql-0.mssql.my-profile.svc.cluster.local;Database=BethanyPieStore;MultipleActiveResultSets=true;User Id=***;Password=****;TrustServerCertificate=True;Encrypt=False;'