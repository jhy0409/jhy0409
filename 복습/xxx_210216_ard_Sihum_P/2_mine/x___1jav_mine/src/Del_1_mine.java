import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

// --------------- 시스템 제어 프로그램 ---------------
// 1. TV켜기		LED ON
// 2. TV끄기		LED OFF
// 3. 보일러 동작	BUZZER
// 4. 세탁기 동작	SERVO
// 5. 프로그램 종료
// 선택메뉴 : 1

// 가전 제어 : Relay 220V

// <개발순서>
// 1. 라이브러리 연결			>	2. 사용 가능포트 확인
// 3. 시리얼 포트 오픈 + 초기화	>	4. 메뉴에서 명령어 전송
public class Del_1_mine {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int HEAT_ON = 3;
	static final int SETAKGI = 4;
	static final int PSOFF = 5;

	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '0';
	static final int CMD_HEAT_ON = '2';
	static final int CMD_SETAKGI = '3';

	public static SerialPort initSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort = new SerialPort(portNames[0]);

		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
					SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}

		return serialPort;
	}

	public static void main(String[] args) {
		SerialPort serial = initSerial();
		Scanner s = new Scanner(System.in);
		while (true) {
			switch (menuList(s)) {
			case TV_ON:
				System.out.println("tv on");
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case TV_OFF:
				System.out.println("tv off");
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case HEAT_ON:
				System.out.println("heat on");
				try {
					serial.writeInt(CMD_HEAT_ON);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case SETAKGI:
				System.out.println("setak on");
				try {
					serial.writeInt(CMD_SETAKGI);
				} catch (SerialPortException e) {
					e.printStackTrace();
				}
				break;
			case PSOFF:
				System.out.println("종료한다.");
				s.close();
				System.exit(0);
				break;

			}
		}
	}

	public static int menuList(Scanner s) {
		System.out.println("--------------------");
		System.out.println("1. TV켜기");
		System.out.println("2. TV끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 프로그램 종료");
		System.out.println("--------------------");
		System.out.print("메뉴선택 : ");
//		int n = s.nextInt();
//		return n;

		return s.nextInt();
	}
}
