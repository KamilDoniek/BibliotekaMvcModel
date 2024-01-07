# BibliotekaMvcModel

## Instalacja

1. Sklonuj repozytorium:
  
   git clone https://github.com/KamilDoniek/BibliotekaMvcModel.git

## Konfiguracja 

1. w pliku appsettings.json skonfiguruj ConnectionStrings
2. Następnie uruchom migracje
 - Add-Migration "Initial Create"
 - Update-Database
  
### rider   

 - dotnet add package Microsoft.EntityFrameworkCore.Design
 - dotnet tool install --global dotnet-ef
 
 - dotnet ef migrations add new 
 - dotnet ef database update


## Testowi Użytkownicy 

1. Admin(ma możliwość dodawania,usuwania,edytowania danych):
   - admin@admin.com
   - Test123!
2. Manager(ma możliwość dodawania i edytowania danych):
   - manager@manager.com
   - Test123!
     
3. Member(ma możliwość dodawania danych):
   - member@member.com
   - Test123!

## Działanie Apliakcji 

1. Uruchom aplikację.
2. Zaloguj się używając danych testowego użytkownika.
3. W zakładce Autorzy , Ksiązki  jest możliwość dodawania nowych danych,
4. W zakładce Czytelnicy można dodawać nowych czytelników którym możemy dopisywać karte czytelnika
5. W zakładce wypożyczenia wybieramy  id czytelnika i id książki która chcemy wypożyczyć


   
    
    
    
    

