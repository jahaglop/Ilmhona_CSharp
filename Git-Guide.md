# Руководство по Git для начинающих

Git - это система контроля версий, которая помогает отслеживать изменения в коде и сотрудничать с другими разработчиками.

## 📥 Установка Git

### Windows
1. **Скачайте Git:**
   - Перейдите на https://git-scm.com/download/win
   - Скачайте последнюю версию для Windows

2. **Установите Git:**
   - Запустите скачанный .exe файл
   - Следуйте инструкциям установщика
   - Рекомендуется оставить настройки по умолчанию

3. **Проверьте установку:**
   ```bash
   git --version
   ```

### macOS
```bash
# Через Homebrew (рекомендуется)
brew install git

# Или скачайте с официального сайта
# https://git-scm.com/download/mac
```

### Linux (Ubuntu/Debian)
```bash
sudo apt update
sudo apt install git
```

## ⚙️ Первоначальная настройка

После установки настройте Git с вашей информацией:

```bash
# Установите ваше имя
git config --global user.name "Ваше Имя"

# Установите ваш email
git config --global user.email "your.email@example.com"

# Проверьте настройки
git config --list
```

## 📚 Основные команды Git

### Создание репозитория

```bash
# Создать новый репозиторий в текущей папке
git init

# Клонировать существующий репозиторий
git clone https://github.com/username/repository.git
```

### Отслеживание изменений

```bash
# Посмотреть статус файлов
git status

# Добавить файл в отслеживание
git add filename.cs

# Добавить все файлы
git add .

# Зафиксировать изменения (commit)
git commit -m "Описание изменений"

# Посмотреть историю коммитов
git log
```

### Работа с ветками (branches)

```bash
# Посмотреть все ветки
git branch

# Создать новую ветку
git branch new-feature

# Переключиться на ветку
git checkout new-feature

# Создать и переключиться на новую ветку
git checkout -b new-feature

# Объединить ветку с текущей
git merge new-feature

# Удалить ветку
git branch -d new-feature
```

### Работа с удаленными репозиториями

```bash
# Добавить удаленный репозиторий
git remote add origin https://github.com/username/repository.git

# Отправить изменения на GitHub
git push origin main

# Получить изменения с GitHub
git pull origin main

# Посмотреть удаленные репозитории
git remote -v
```

## 🎯 Практический пример для проекта C#

Давайте настроим Git для вашего проекта C#:

### 1. Инициализация репозитория
```bash
# Перейдите в папку с проектом C#
cd "C:\Users\ziyae\Downloads\c#"

# Инициализируйте Git репозиторий
git init
```

### 2. Создайте файл .gitignore
Создайте файл `.gitignore` чтобы исключить ненужные файлы:

```
# Исполняемые файлы
*.exe
*.dll
*.pdb

# Папки Visual Studio
bin/
obj/
.vs/

# Файлы пользователя
*.user
*.suo

# Временные файлы
*.tmp
*.temp
```

### 3. Добавьте файлы в репозиторий
```bash
# Добавить все файлы проекта
git add .

# Создать первый коммит
git commit -m "Начальный коммит: структура проекта C#"
```

### 4. Подключите к GitHub (опционально)
```bash
# Добавьте удаленный репозиторий (замените на ваш URL)
git remote add origin https://github.com/ваш-username/csharp-learning.git

# Отправьте код на GitHub
git push -u origin main
```

## 📋 Типичный рабочий процесс

### Ежедневная работа с Git:

1. **Начало работы:**
   ```bash
   git status              # Проверить состояние
   git pull origin main    # Получить последние изменения
   ```

2. **Работа с кодом:**
   - Редактируйте файлы в VS Code или Visual Studio
   - Тестируйте ваш код

3. **Сохранение изменений:**
   ```bash
   git add .                           # Добавить все изменения
   git commit -m "Добавлен класс Car"  # Создать коммит
   git push origin main                # Отправить на GitHub
   ```

### Хорошие практики для сообщений коммитов:

- **Добавлен:** новый функционал
- **Исправлен:** исправление ошибки
- **Обновлен:** изменение существующего кода
- **Удален:** удаление кода

Примеры:
```bash
git commit -m "Добавлен класс Автомобиль в проект"
git commit -m "Исправлена ошибка в методе Калькулятора"
git commit -m "Обновлен README с инструкциями"
git commit -m "Удален неиспользуемый код в HelloWorld"
```

## 🔧 Полезные команды для начинающих

```bash
# Отменить изменения в файле (до add)
git checkout -- filename.cs

# Убрать файл из staging area
git reset filename.cs

# Посмотреть различия в файлах
git diff

# Посмотреть различия для конкретного файла
git diff filename.cs

# Посмотреть краткую историю
git log --oneline

# Посмотреть изменения в последнем коммите
git show
```

## 🆘 Решение типичных проблем

### Забыли добавить файл в коммит:
```bash
git add forgotten-file.cs
git commit --amend --no-edit
```

### Хотите отменить последний коммит (но сохранить изменения):
```bash
git reset --soft HEAD~1
```

### Конфликт при merge:
1. Откройте файлы с конфликтами
2. Найдите строки с `<<<<<<<`, `=======`, `>>>>>>>`
3. Исправьте конфликты вручную
4. Сохраните файлы
5. Выполните:
   ```bash
   git add .
   git commit -m "Разрешен конфликт merge"
   ```

## 🔒 Настройка разрешений репозитория (только для владельца)

Если вы хотите, чтобы только вы могли делать push в репозиторий, есть несколько способов:

### На GitHub:

#### 1. Приватный репозиторий (рекомендуется)
```bash
# При создании репозитория на GitHub выберите "Private"
# Это ограничит доступ только для вас
```

**Шаги на GitHub.com:**
1. Перейдите на github.com
2. Нажмите "New repository"
3. Выберите **"Private"** вместо "Public"
4. Только вы сможете видеть и изменять репозиторий

#### 2. Настройка Branch Protection (для публичных репозиториев)
Если репозиторий публичный, но вы хотите контролировать изменения:

**На сайте GitHub:**
1. Откройте ваш репозиторий на GitHub
2. Перейдите в **Settings** → **Branches**
3. Нажмите **"Add rule"**
4. В поле "Branch name pattern" введите `main` или `master`
5. Включите опции:
   - ✅ **"Restrict pushes that create files"**
   - ✅ **"Require pull request reviews before merging"**
   - ✅ **"Include administrators"**

#### 3. Управление Collaborators
```bash
# Не добавляйте других пользователей как Collaborators
# Settings → Manage access → Collaborators
```

### Локальные настройки:

#### Защита с помощью SSH ключей
```bash
# Сгенерируйте SSH ключ (только на вашем компьютере)
ssh-keygen -t ed25519 -C "your.email@example.com"

# Добавьте публичный ключ на GitHub
# Settings → SSH and GPG keys → New SSH key

# Клонируйте репозиторий через SSH
git clone git@github.com:username/repository.git
```

#### Настройка удаленного репозитория только для вас
```bash
# Используйте HTTPS с персональным токеном
# GitHub → Settings → Developer settings → Personal access tokens

# Клонируйте с токеном
git clone https://ghp_ваш_токен@github.com/username/repository.git

# Или настройте после клонирования
git remote set-url origin https://ghp_ваш_токен@github.com/username/repository.git
```

### Практический пример для вашего проекта C#:

```bash
# 1. Создайте приватный репозиторий на GitHub
# 2. Инициализируйте локальный репозиторий
cd "C:\Users\ziyae\Downloads\c#"
git init

# 3. Подключите к приватному репозиторию
git remote add origin https://github.com/ваш-username/csharp-learning-private.git

# 4. Сделайте первый push
git add .
git commit -m "Начальный коммит: приватный проект C#"
git push -u origin main
```

### Дополнительная безопасность:

#### Двухфакторная аутентификация (2FA)
1. GitHub → Settings → Account security
2. Включите **"Two-factor authentication"**
3. Это защитит ваш аккаунт от несанкционированного доступа

#### Настройка Git Hooks (продвинутый уровень)
```bash
# Создайте pre-push hook для дополнительной проверки
# В папке .git/hooks/ создайте файл pre-push

#!/bin/sh
echo "Проверка перед push..."
echo "Только владелец может делать push!"
# Добавьте свою логику проверки
```

### Проверка настроек:

```bash
# Проверьте настройки удаленного репозитория
git remote -v

# Проверьте статус аутентификации
git config --list | grep user

# Проверьте SSH подключение (если используете SSH)
ssh -T git@github.com
```

### ⚠️ Важные моменты:

1. **Никогда не делитесь:**
   - Персональными токенами доступа
   - Приватными SSH ключами
   - Паролем от GitHub аккаунта

2. **Регулярно обновляйте:**
   - Токены доступа (каждые 6-12 месяцев)
   - SSH ключи при необходимости

3. **Мониторьте активность:**
   - Проверяйте историю коммитов: `git log`
   - Следите за уведомлениями GitHub

### Резервное копирование:

```bash
# Создайте локальную резервную копию
git clone --mirror https://github.com/username/repository.git backup.git

# Или просто скопируйте всю папку проекта в безопасное место
```

## 🎓 Дальнейшее изучение

После освоения основ изучите:
- **GitHub Desktop** - графический интерфейс для Git
- **GitLab/Bitbucket** - альтернативы GitHub
- **Git Flow** - стратегия ветвления
- **Pull Requests** - процесс код-ревью
- **Git Hooks** - автоматизация задач

## 📱 Полезные инструменты

### Графические интерфейсы:
- **GitHub Desktop** - бесплатный, простой
- **SourceTree** - мощный, бесплатный
- **GitKraken** - красивый интерфейс

### Расширения для VS Code:
- **GitLens** - расширенная Git интеграция
- **Git Graph** - визуализация истории
- **Git History** - просмотр истории файлов

## 🔗 Полезные ссылки

- [Официальная документация Git](https://git-scm.com/docs)
- [GitHub Guides](https://guides.github.com/)
- [Интерактивный учебник Git](https://learngitbranching.js.org/?locale=ru_RU)
- [Pro Git книга (бесплатно)](https://git-scm.com/book/ru/v2)

---

**Помните:** Git может показаться сложным сначала, но с практикой он станет незаменимым инструментом! Начните с основных команд и постепенно изучайте более продвинутые возможности.

*Удачи в изучении Git!* 🚀
