#ifndef PARSE_H
# define PARSE_H

# include "../libft/libft.h"
# include "get_next_line.h"
# include <sys/types.h>
# include <dirent.h>
# include <stdlib.h>
# include <unistd.h>
# include <sys/stat.h>
# include <fcntl.h>
# include <sys/wait.h>
# include <sys/time.h>
# include <sys/resource.h>
# include <signal.h>

# define SEMICOLON 	1
# define AND 		2
# define OR 		3
# define PIPE 		4
# define LESS 		5
# define MORE 		6
# define DBLESS 	7
# define DBMORE 	8
# define COMMAND	9

extern char			**environ;

typedef struct 		s_tree
{
	int				type;
	char			*content;
	struct s_tree	*left;
	struct s_tree	*right;
} 					t_tree;


void	free_tree(t_tree *tree);
void	free_tab(char **tab);
void	parse(t_tree *tree);
int		dotcoma(t_tree *tree);
t_tree		*create_node(void);
int		and_or(t_tree *tree);
int		redirections(t_tree *tree);
void	pipe_tree(t_tree *tree, char *chr, int len);
void	dbless_tree(t_tree *tree, char *chr, int len);
void	dbmore_tree(t_tree *tree, char *chr, int len);
void	less_tree(t_tree *tree, char *chr, int len);
void	more_tree(t_tree *tree, char *chr, int len);


#endif
