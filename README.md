# Dopamine
Приложение электронной торговой площадки.

## Содержание
- [Технологии](#технологии)
- [Использование](#использование)
- [Требования](#требования)

## Технологии
- .NET Framework 3.5
- C#
- MySQL
- phpMyadmin

## Использование
Файл базы данных dopamine.sql находится в корне проекта. Для тестового запуска сервера можно использовать OpenServer Panel, а для управления использовать phpMyAdmin.

Для запуска перейдите по ветке bin\Debug\. Запустите исполняемый файл Dopamine.exe

После запуска в шапке будет надпись "Сервер не найден", так как приложение не может подключиться к базе данных.
<img width="957" height="586" alt="image" src="https://github.com/user-attachments/assets/9ca61612-25f8-4fd2-9f48-53c4a685b152" />
Чтобы настроить конфигурацию, в папке исполняемого файла открываем файл конфигурации Dopamine.exe.Config и редактируем следующие данные:
```sh
<setting name="IP" serializeAs="String">
      <value>127.0.0.1</value>
</setting>
<setting name="Username" serializeAs="String">
      <value>root</value>
</setting>
<setting name="Password" serializeAs="String">
      <value />
</setting>
<setting name="Database" serializeAs="String">
      <value>dopamine</value>
</setting>
```
- IP - ip адрес сервера с БД
- Username - имя пользователя для входа в СУБД на сервере
- Password - пароль для входа в СУБД на сервере
- Database - имя базы данных

Сохраняем файл, запускаем приложение, и, если все сделано правильно, приложение запустится в режиме гостя, без надписи о том, что сервер не найден.


### Требования

Особых требований к запуску приложения нет.

