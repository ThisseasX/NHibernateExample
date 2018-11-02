# NHibernateExample
Minimalistic example, demonstrating Fluent NHibernate usage on a simple MySQL Database.

# Setup
Edit the App.config file with the proper database credentials:

`<add key="ConnectionString" value="Server=127.0.0.1;Port=3306;Database=test;Uid=USERNAME;Pwd=PASSWORD;SslMode=none;" />`

Note: `SslMode=none` is important if your database is not using SSL.
