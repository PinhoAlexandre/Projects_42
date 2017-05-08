section .text
global _ft_memcpy

_ft_memcpy:
		mov		r10, rdi
		cmp		rdi, byte 0
		je		end
		cmp		rsi, byte 0
		je		end
		cld
		mov		rcx, rdx
		rep		movsb
		jmp		end

end:
		mov		rax, r10
		ret