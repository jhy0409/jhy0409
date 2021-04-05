package com.boxup.addrApp.util;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

import com.boxup.addrApp.model.AddrBook;

public class Menu {
	public static final int CREATE_TABLE = 1;
	public static final int DEL_TABLE = 2;
	public static final int INSERT_DATA = 3;
	public static final int INSERT_RAND_DATA = 4;
	public static final int VIEW_DATA = 5;

	public static final int UPDATE_DATA = 6;
	public static final int DEL_DATA = 7;
	public static final int MAIN_EXIT = 8;

	public int mainMenu(Scanner s) {

		System.out.println("----------------------");
		System.out.println("  MySQL DB 관리 v1.0");
		System.out.println("----------------------");
		System.out.println("1. 테이블 생성");
		System.out.println("2. 테이블 삭제");
		System.out.println("3. 데이터 추가");
		System.out.println("4. 랜덤 데이터 추가");
		System.out.println("5. 데이터 보기\n");
		System.out.println("6. 데이터 수정");
		System.out.println("7. 데이터 삭제");
		System.out.println("8. 종료");
		System.out.println("----------------------");

		System.out.print("메인 메뉴 선택 : ");
		return s.nextInt();
	}

	public AddrBook addMenu(Scanner s) { // present 구조
		System.out.println("----------------------");
		System.out.println("     데이터 추가 메뉴");
		System.out.println("----------------------");
		System.out.print(" 이름 : ");
		String name = s.next();
		System.out.print(" 나이 : ");
		int age = s.nextInt();
		System.out.print(" 전화 : ");
		String tel = s.next();
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.print(" 주소 : ");
		String address = null;
		try {
			address = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.print(" 메일 : ");
		String email = s.next();
		return new AddrBook(name, age, tel, address, email);
	}

	public String[] sujung(Scanner s) {
		String sujung[] = new String[6];
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.println("----------------------");
		System.out.println("     수정 메뉴 (미변경 시 +)");
		System.out.println("----------------------");
		System.out.print("아이디 :");
		sujung[0] = s.next();
		System.out.print(" 이름 : ");
		sujung[1] = null;
		try {
			sujung[1] = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.print(" 나이 : ");
		sujung[2] = null;
		try {
			sujung[2] = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.print(" 전화 : ");
		sujung[3] = null;
		try {
			sujung[3] = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}

		System.out.print(" 주소 : ");
		sujung[4] = null;
		try {
			sujung[4] = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.print(" 메일 : ");
		sujung[5] = null;
		try {
			sujung[5] = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}

		return sujung;
	}

	public int[] delData(Scanner s) {
		System.out.println("----------------------");
		System.out.println("     삭제 인덱스 입력");
		System.out.println("----------------------");
		System.out.println(" 1. 개별");
		System.out.println(" 2. 범위");
		System.out.println("----------------------");
		System.out.print("메뉴선택 : ");
		int[] selNum = new int[4];
		selNum[0] = s.nextInt();
		if (selNum[0] == 1) {
			System.out.print("아이디 입력 : ");
			selNum[1] = s.nextInt();
		}

		else if (selNum[0] == 2) {
			System.out.print("범위 입력1 : ");
			selNum[2] = s.nextInt();
			System.out.print("범위 입력2 : ");
			selNum[3] = s.nextInt();
		}
		return selNum;
	}

}
