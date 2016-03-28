﻿DROP FUNCTION IF EXISTS account.get_name_by_user_id(_user_id integer);
CREATE FUNCTION account.get_name_by_user_id(_user_id integer)
RETURNS text
STABLE
AS
$$
BEGIN
    RETURN
        account.users.name
    FROM account.users
    WHERE account.users.user_id = _user_id;
END
$$
LANGUAGE plpgsql;