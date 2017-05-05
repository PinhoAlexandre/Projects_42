#ifndef SH_H
# define SH_H

# include "../libft/libft.h"
# include "get_next_line.h"
# include <unistd.h>
# include <sys/stat.h>
# include <sys/wait.h>
# include <sys/ioctl.h>
# include <sys/time.h>
# include <sys/resource.h>
# include <stdlib.h>
# include <termios.h>
# include <term.h>
# include <fcntl.h>
# include <sys/types.h>
# include <sys/uio.h>
# include <signal.h>
# include <dirent.h>

# define WORDS		0
# define DQUOTE		1
# define SQUOTE		2
# define OR			3
# define AND		4
# define PIPE		5
# define DLESS		6
# define DMORE		7
# define LESS		8
# define MORE		9
# define END_LINE	10

typedef struct 			s_token
{
	int			type;
	char		*lexeme;
	t_token		*next;
}						t_token;

typedef struct 			s_all
{
	char				*line;
	char				*epured_line;
	t_token				*token;
}						t_all;

void	check_ope(token, line, pos, i);
int		ft_isprintnotope(char c);
void	print_tokens(t_token *token);
void	analise_line(t_all *all);
int		lire_lexeme(t_token *token, char *line, int pos);
void	add_lexeme(t_token *token, char *line, int pos, int i);
int		ft_isope(char c);

#endif