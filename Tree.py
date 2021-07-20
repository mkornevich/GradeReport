Проект - ProjectNode
	+Конфигурация - ConfigNode
	+Предметы - SubjectListNode
		+Предмет - SubjectNode
	+Квалификации - QualificationListNode
		+Квалификация - QualificationNode
				+Специальность - SpecialtyNode
	+Группы - GroupListNode
		+Группа - GroupNode
			+Студетны - StudentListNode
				+Студент - StudentNode
			+Предметы - GroupSubjectRefListNode
				+Предмет - GroupSubjectRefNode
					+Мои студенты - MyStudentInSubjectRefListNode
						+Студент - MyStudentInSubjectRefNode
			Курсы - CourseListNode
				Курс - CourseNode
					Семестры - SemesterListNode
						Семестр - SemesterNode
							Студенты - SemesterStudentRefListNode
								Студент - SemesterStudentRefNode
							Предметы - SemesterSubjectRefListNode
								Предмет - SemesterSubjectRefNode




Типы валидаций
	Создание одного объекта (можно ли создать)
	Редактирование одного существующего объекта
	Удаление одного существующего объекта
	Изменение списка связей
	
Validator
	CanCreateEntity(): bool
	CanRemoveEntity(entity): bool
	CanUpdateRefs(list newRefs): bool
	ValidateEntity(entity): bool



Создание одного нового объекта
	- Проверка на то можно ли тут создать новый объект
	- Создание нового объекта
	- Открытие его в редакторе
	- После редактирования запуск валидатора
	- Сохранение или сообщение об ошибке
	
Редактирование одного существующего объекта
	- После редактирования запуск валидатора
	
Удаление одного существующего объекта (удаление только когда все в порядке и нет зависимостей)
	- Проверка отсутствия внешних ссылок
	- Проверка произвольных доп правил
	- Либо ошибка либо удаление
	
Изменение списка связей
	- Проверка на конфликт с другими связями
	- Проверка доп условий


Редактирование объекта










Group
Subject
Student
Specialty (Specialty Qualification)
Semester
Course
Period

























