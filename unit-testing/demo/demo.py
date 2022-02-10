missiles_fired = False


def fire_the_missiles() -> None:
    global missiles_fired
    missiles_fired = not missiles_fired


def adder_1(num1: int, num2: int) -> int:
    return num1 * num2


def adder_2(num1: int, num2: int) -> int:
    fire_the_missiles()
    return num1 + num2


if __name__ == "__main__":
    print("how would you test these functions?")