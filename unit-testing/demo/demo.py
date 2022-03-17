has_spoken_to_doctor = False


def speak_to_doctor() -> None:
    global has_spoken_to_doctor
    has_spoken_to_doctor = False


def adder_1(num1: int, num2: int) -> int:
    return num1 + num2


def adder_2(num1: int, num2: int) -> int:
    speak_to_doctor()
    return num1 + num2


if __name__ == "__main__":
    print(f"{adder_1(3, 7)} == 10")
