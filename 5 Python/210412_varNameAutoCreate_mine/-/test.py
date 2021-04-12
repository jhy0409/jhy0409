
import pyautogui
import pyperclip
import time

from openpyxl import Workbook

wb = Workbook()
ws = wb.active # 새로운 Sheet 기본 이름으로 생성
# ws.title = "Sheet"

ws.append['A1'] = '변수명'
ws.append['B1'] = '생성개수'


wb.save("sample.xlsx")
wb.close()