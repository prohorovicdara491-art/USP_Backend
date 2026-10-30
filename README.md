## База данных: `uspk_db`
Таблица: **`users`**

### Структура таблицы (SQL)
```sql
CREATE TABLE Users (
    Id          SERIAL PRIMARY KEY,
    Username    VARCHAR(50)  NOT NULL,
    Email       VARCHAR(100) NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    Role        VARCHAR(20)  NOT NULL DEFAULT 'User',
    CreatedAt   TIMESTAMP    NOT NULL DEFAULT (CURRENT_TIMESTAMP AT TIME ZONE 'UTC'),
    CONSTRAINT UQ_Users_Email    UNIQUE (Email),
    CONSTRAINT UQ_Users_Username UNIQUE (Username)
);

---

В файле appsettings.json строка подключения:


"DefaultConnection": "Host=localhost;Port=5432;Database=uspk_db;Username=postgres;Password=0575"
