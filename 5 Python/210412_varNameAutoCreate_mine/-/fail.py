import pyautogui
import pyperclip
import time

pyautogui.hotkey('ctrl','c')
pyautogui.hotkey('win')
pyautogui.write('excel')
pyautogui.press('enter')
time.sleep(4)
pyautogui.hotkey('alt','c')
time.sleep(1)

pyautogui.hotkey('f2')
pyautogui.hotkey('ctrl','v')
pyautogui.hotkey('tab')

pyautogui.hotkey('f2')
pyperclip.copy('생성 개수를 입력하시오') 
pyautogui.hotkey('ctrl','v')
time.sleep(1)
pyautogui.hotkey('tab')
