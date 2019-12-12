# Unity_OOP_Game_Example
Я создавал этот проект с целью тренировки своих навыков  ООП, поэтому хотел бы обратить ваше вниман именно на объектную модель, а не физику, геймплей, графику и т.п.

Эта объектная модель позволяет создавать новые классы врагом, а так же новые скрипты поведения для них, не затрагивая при этом уже существующий код.

Описание игры:
Цель игры заключается в том, чтобы поместить красный куб(AgressiveEnemy)в заданную точку(кпасный цилиндр).

Основные объекты в игре:
- Player(просто передвигается)
- BigEnemy(убегает от игрока, но если рядом есть стена нападает)
- SmallEnemy(убегает от игрока, но если рядом есть стена или BigEnemy нападает)
- AgressiveEnemy(нападает на игрока, но убегает если рядом BigEnemy или SmallEnemy)
- Point(загадочно мерцает и ждет AgressiveEnemy, чтобы сменить сцену)

Unity 2019.2.10f1
