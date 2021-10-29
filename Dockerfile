FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
EXPOSE 443/tcp
ENV ASPNETCORE_ENVIRONMENT=Development
ENTRYPOINT ["dotnet", "Assignment1.dll"]