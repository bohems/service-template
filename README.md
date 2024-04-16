Создайте новый сервис, используя готовый шаблон.
###### Внимение, данный шаблон предназначен только для http://git.dextechnology.com/apptemplate/back

### Установите шаблон:
1. **Скачайте шаблон сервиса**

    ```
    dotnet new install Dex.Template.Service
    ```

2. **Откройте терминал в IDE (Rider, Visual Studio) и выполните команду**

    ```
    dotnet new service -n ИмяСервиса -F Версия
    ```

    Где:
    - `-n` - имя сервиса, например: Admin, Notification, Profile (обязательно)
    - `-F` - версия dotnet для .csproj, например: net6.0, net7.0, net8.0 (не обязательно, по умолчанию net6.0)

### Базовый курс по работе с шаблонами:
Быстрый пятиминутный курс по работе с dotnet new и шаблонами на примере нашего Template  
https://wide-gallon-4e7.notion.site/Templates-dotnet-new-87fc400b7efe4266833cd123cfcebc2d
