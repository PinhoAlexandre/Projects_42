section .data
	new_line db 10

section .text
global _ft_puts
extern _ft_strlen

_ft_puts:
	cmp rdi, 0
	je null
	
msg:
	push rdi
	call _ft_strlen
	mov rdx, rax
	pop rsi
	mov rdi, 1
	mov rax, 0x2000004
	syscall
	jc error

back_n:
	mov rax, 0x2000004
	mov rdi, 1
	lea rsi, [rel new_line]
	mov rdx, 1
	syscall
	jc error
	jmp finish

null:
	mov rax, 0x2000004
	mov rdi, 1
	lea rsi, [rel null_msg]
	mov rdx, 7
	syscall
	jc error
	jmp finish

null_msg:
	db "(null)", 10

error:
	mov rax, -1
	ret

finish:
	ret