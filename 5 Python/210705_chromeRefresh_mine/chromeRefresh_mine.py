import pyautogui
import time

def refresh():
    pyautogui.hotkey('ctrl','r')

j = 3301

time.sleep(2)
for i in range(j, 11331):
    refresh()
    j += 1
    print(j)
    time.sleep(2.5)
