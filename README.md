# Calcu1 Calculator (WinForms)

Десктопний калькулятор на C# (WinForms, .NET Framework). Має 2 режими:
- "Дві змінних": +, -, *, /
- "Одна змінна": A^2, 1/A, sin, cos, tan, ctn
Також є очищення (C) і пам’ять (->M, M->) та кнопка "Мій інтерфейс".

## Як запустити
1. Відкрити `calcu1.sln` у Visual Studio
2. Натиснути Start (F5)

## Як запустити тести
1. Відкрити рішення у Visual Studio
2. Test → Run All Tests

## Структура проєкту
- `calcu1.sln` — solution
- `calcu1/` — основна WinForms програма
  - `Form1.cs` — логіка інтерфейсу (кнопки)
  - `Form1.Designer.cs` — розмітка форми (UI)
  - `MathFuctions.cs` — логіка обчислень (calc)
  - `Program.cs` — запуск програми
- `calcu1.Tests/` — unit-тести (буде додано)
- `.github/workflows/` — автозапуск тестів на GitHub (буде додано)
