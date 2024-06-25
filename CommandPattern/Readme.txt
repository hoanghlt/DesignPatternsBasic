ICommand
	Execute()
	Undo()

Light
	Đối tượng light on, light off

Garage
	Đối tượng Garage: Open, Close

LightOffCommand: kế thừa ICommand
	Dựng 1 đối tượng Light, khởi tạo trong hàm dựng
	thực hiện Execute => Off, Undo => On

LightOnCommand: kế thừa ICommand
	Dựng 1 đối tượng Light, khởi tạo trong hàm dựng
	thực hiện Execute => On, Undo => Off

GarageDoorCloseCommand: kế thừa ICommand
	Dựng 1 đối tượng Garage, khởi tạo trong hàm dựng
	Thực hiện Execute => Close, Undo => Open

GarageDoorOpenCommandkế thừa ICommand
	Dựng 1 đối tượng Garage, khởi tạo trong hàm dựng
	Thực hiện Execute => Open, Undo => Close

MacroCommand: kế thừa ICommand
	Thực hiện khỏi tạo 1 list các ICommand
	Execute => chạy các execute của các command
	Undo => chạy các Undo của các command

NoCommand: kế thừa từ ICommand
	Execute => No command Assigned
	Undo => Execute

struct OnOffStruct
	Tạo 1 struct chứa 2 ICommand On, Off

RemoteControl:
	Khởi tạo 2 list danh sách On, Off command, thực hiện Gán giá trị khởi tạo cho các slots trong list
	Thực hiện 
		PushOn(i) => commandOn[i].execute, UndoCommand = CommandOff[i]
		PushOff(i) => CommandOff[i].execute, UndoCommand = CommandOn[i], 
		PushUndo => UndoCommand.execute

Command pattern là một pattern cho phép bạn chuyển đổi một request thành một object độc lập chứa tất cả thông tin về request. 
Việc chuyển đổi này cho phép bạn tham số hoá các methods với các yêu cầu khác nhau như log, queue (undo/redo), transtraction.

=> Trong ví dụ trên ta có thể sử dụng remote control xử lý từng đối tượng trong list dữ liệu, hoặc có thể sử dụng 1 MacroCommand
để xử lý nhiều đối tượng cùng lúc
