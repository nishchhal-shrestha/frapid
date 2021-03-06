# hrm.employment_status_codes table



| # | Column Name | Nullable | Data Type | Max Length | Description |
| --- | --- | --- | --- | --- | --- |
| 1 | employment_status_code_id | [ ] | integer | 0 |  |
| 2 | status_code | [ ] | character varying | 12 |  |
| 3 | status_code_name | [ ] | character varying | 100 |  |
| 4 | audit_user_id | [x] | integer | 0 |  |
| 5 | audit_ts | [x] | timestamp with time zone | 0 |  |
| 6 | deleted | [x] | boolean | 0 |  |



**Foreign Keys**

| # | Column Name | Key Name | References |
| --- | --- | --- | --- |
| 4 | [audit_user_id](../account/users.md) | employment_status_codes_audit_user_id_fkey | account.users.user_id |



**Indices**

| Index Name | Owner | Access Method | Definition | Description |
| --- | --- | --- | --- | --- |
| employment_status_codes_pkey | frapid_db_user | btree | employment_status_code_id |  |
| employment_status_codes_status_code_key | frapid_db_user | btree | status_code |  |
| employment_status_codes_status_code_uix | frapid_db_user | btree | upper(status_code::text) |  |
| employment_status_codes_status_code_name_uix | frapid_db_user | btree | upper(status_code_name::text) |  |



**Check Constraints**

| Constraint Name | Description |
| --- | --- |



**Default Values**

| # | Column Name | Default |
| --- | --- | --- |
| 5 | audit_ts | now() |
| 6 | deleted | false |


**Triggers**

| Trigger Name | Targets | On Event | Timing | Condition | Order | Orientation | Description |
| --- | --- | --- | --- | --- | --- | --- | --- |


### Related Contents
* [Schema List](../../schemas.md)
* [Table List](../../tables.md)
* [Sequence List](../../sequences.md)
* [Table of Contents](../../README.md)
