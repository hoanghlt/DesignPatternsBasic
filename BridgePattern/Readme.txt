Interface Phép thuật:
	Func: OnActivate
	Func: Apply
	Func: OnDeactivate

Interface vũ khí:
	Func Wield
	Func Swing
	Func Unwield
	Func Get phép thuật: trả về phép thuật của đối tượng

Đối tượng cái búa: Kế thừa từ vũ khí
	Sử dụng Dependency Injection, inject Interface phép thuật trong hàm dựng
	func: Wield => Func: OnActivate
	func: Swing => Func: Apply
	func: Unwield => Func: Unwield

Đối tượng cái kiếm: Kế thừa từ vũ khí
	Sử dụng Dependency Injection, inject Interface phép thuật trong hàm dựng
	func: Wield => Func: OnActivate
	func: Swing => Func: Apply
	func: Unwield => Func: Unwield

Đối tượng phép thuật: kế thừa từ phép thuật
	- Flying Enchantment
	- Soul Eating Enchantment

FUNC MAIN:
	Tạo 1 đối tượng là cái búa nó sẽ có phép thuật là Soul eating
	Tạo 1 đối tượng là cái kiếm nó sẽ có phép thuật là flying

==> Bridge Pattern là một mẫu cấu trúc trong lập trình, thuộc nhóm Structural Pattern. 
Ý tưởng của nó là tách tính trừu tượng (abstraction) ra khỏi tính hiện thực (implementation) của nó. 
Từ đó, có thể dễ dàng chỉnh sửa hoặc thay thế mà không làm ảnh hưởng đến những nơi có sử dụng lớp ban đầu.

==> Ở ví dụ này ta thấy: ban đầu ta có 1 đối tượng vũ khí sẽ có các chức năng cần thiết của 1 vũ khí,
ban đầu chỉ có búa với chức năng và phép thuật là Soul eating, sau đó phát triển hơn thì nó sản sinh ra 
nhiều loại đối tượng có phép thuật mới lúc này chúng ta chỉ cẩn tạo 1 inject trong interface vũ khí ban đầu,
để có thể truyền bất khỏi tạo bất cứ đối tượng nào hiện có với những phép thuật mới.
