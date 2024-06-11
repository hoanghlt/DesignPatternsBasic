Đối tượng hamburger:
	attr: Size
	attr: Shape
	attr: Ingredients
	func override: ToString

Interface Builder:
	func AddIngredients,
	func AddShape,
	func AddSize,
	func Reset,
	func Build

Chức năng Cook:
	inject IBuilder
	func: ChangeBuilder thực hiện gọi AcceptBuilder để tạo 1 đối tượng mới từ đối tượng truyền vào.
	func: Build thực hiện các chức năng của builder.
	func: AcceptBuilder thực hiện tạo mới lại đối tượng Builder truyền vào.

Các đối tượng builder: kế thừa IBuilder
	Khai báo cấu hình hamburger muốn tạo
	- hamburger của tôi
	- Hamburger của vợ tôi

==> Builder Pattern là một mẫu thiết kế thuộc nhóm Creational Pattern trong lập trình hướng đối tượng. 
Mục đích chính của nó là tách riêng việc khởi tạo một đối tượng ra khỏi biểu diễn của nó
Cụ thể, Builder Pattern cho phép lập trình viên tạo ra các đối tượng phức tạp bằng cách 
sử dụng các câu lệnh đơn giản để tác động lên các thuộc tính của đối tượng đó. 
Điều này giúp quản lý việc khởi tạo đối tượng một cách linh hoạt và dễ dàng hơn.

==> Ở ví dụ này là việc làm hamburger giữa tôi và vợ, mỗi người sẽ làm ra những sản phẩm khác nhau 
về nguyên liệu, hình dáng, kích cỡ, ... nhưng sẽ có cac thuộc tính giống nhau đó là đều cần nguyên liệu,
hình dáng sẽ làm ra, kích cỡ bánh như thế nào, ... từ đó chúng ta sẽ dựng 1 interface cấu hình để sử dung chung
khi làm bánh, 1 lớp làm bánh sẽ inject cấu hình này vào và thực hiện làm bánh. Từ đó nếu có 1 ai đó muốn tự tạo ra 
hamburger cho mình thì sẽ tự tạo cho mình 1 cầu hình và đẩy vào làm bánh.