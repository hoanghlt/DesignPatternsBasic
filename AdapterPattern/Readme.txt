Interface vịt: 
	func: kêu
	func: bay

Interface gà tây:
	func: ăn
	func: bay

Đối tượng vịt trời: kế thừa từ vịt
	func: kêu
	func: bay

Đối tượng gà tây hoang dả: kế thừa từ gà tây
	func: ăn
	func: bay

Bộ chuyển đổi gà tây: kế thừa từ vịt
	khởi tạo 1 con gà tây
	func: kêu => gà tây kêu
	func: bay => gà tây bay

==> adapter pattern là một mẫu thiết kế phần mềm, Adapter Pattern nằm trong nhóm Cấu trúc — 
Structural Pattern — liên quan đến cấu trúc cho toàn hệ thống, 
tập trung vào các mối quan hệ giữa các thực thể, các component, 
làm cho chúng tương tác dễ dàng với nhau hơn. Adapter Pattern đóng vai trò trung gian, 
tương thích cho hệ thống sẵn có đối ứng với các component mới mà không cần phải sửa đổi code, 
cho phép các interface không liên quan đến nhau có thể làm việc cùng nhau.

==> có 1 ví dụ đơn giản về adapter pattern đó là bạn có thể tưởng tượng việc sử dụng cục chuyển 
đổi để kết nối ổ cắm 3 chân của một thiết bị với ổ cắm 2 chân của một nguồn điện khác nhau

==> trong TurkeyAdapter ta có hàm viết lại Fly từ IDuck, ta thấy các con vịt sẽ bay được 500miles, 
tuy nhiên Turkey chỉ bay được 100miles, do vậy khi chuyển đổi thông qua bộ TurkeyAdapter ta sẽ thấy 
chạy vòng lặp 5 lần để đồng bộ chính xác như 1 con vịt trời bay 500miles.