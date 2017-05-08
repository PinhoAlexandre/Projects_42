section .data
	buf		db 0

section .text
global _ft_cat

_ft_cat:
	push	r15
	cmp		rdi, 0
	jl		over
	mov		r15, rdi

while:
	mov		rax, 0x2000003
	mov		rdi, r15
	lea		rsi, [rel buf]
	mov		rdx, 1
	syscall
	jc		over
	cmp		rax, 1
	jne		over
	mov		rdx, rax
	mov		rax, 0x2000004
	mov		rdi, 1
	lea		rsi, [rel buf]
	syscall
	jc		over
	jmp		while

over:
	xor		rax, rax
	pop		r15
	ret

