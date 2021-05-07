프로그램 사용 방법

1. db(=schema)를 만든다.(한글파일 참고)
	- db 이름 및 table 구조
	- 비밀번호 바꾸는 부분(이 것도 파일화 시켜도 되긴 한데 귀찮...)
	- db 버전
2. 비밀번호가 맞지 않으면 바꾼다(ConnectDB() 함수 고치기. DBHelper가 총 4개다.)
부모가 되는 DBHelper가 있고 mssql, mysql, oracle용 DBHelper가 있다.
3. bin 폴더 안에 있는 data.csv 파일의 첫번째 줄 숫자를 바꾼다.
0 - xml
1 - json
2 - mssql
3 - mysql
4 - oracle

소스를 보면 알겠지만 2번째 줄에 있는 내용을 배열화시켜서 그 중 하나를 가져온 것이다.